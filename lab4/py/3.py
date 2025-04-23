import tkinter as tk
from tkinter import messagebox
from datetime import datetime
import os

log_file = "Session log.txt"
input_file = "Input data.txt"
output_file = "Output data.txt"

def log_action(action):
    with open(log_file, "a") as f:
        f.write(f"{action}\n")

def clear_log():
    open(log_file, "w").close()
    log_action("Дія 1: додаток запущено")

def import_data():
    try:
        with open(input_file, "r") as f:
            data = f.read().strip()
        e1.delete(0, tk.END)
        e2.delete(0, tk.END)
        val1, val2 = data.split()
        e1.insert(0, val1)
        e2.insert(0, val2)
        log_action("Дія 2: обрано «Імпортувати вхідні дані»")
    except Exception:
        messagebox.showerror("Помилка", "Файл порожній або неправильні дані")

def calculate():
    try:
        a = float(e1.get())
        b = float(e2.get())
        op = var.get()
        log_action(f"Дія 3: обрано арифметичну операцію «{op}»")

        if op == "/" and b == 0:
            raise ZeroDivisionError

        result = {
            "+": a + b,
            "-": a - b,
            "*": a * b,
            "/": a / b,
            "^": a ** b,
        }[op]

        result_text = f"{a} {op} {b}, Результат: {result}"
        label_result.config(text=result_text)
        log_action("Дія 4: обрано «Обчислити вираз»")

    except ZeroDivisionError:
        messagebox.showerror("Помилка", "Ділення на 0 заборонено")
    except Exception:
        messagebox.showerror("Помилка", "Недопустимі значення введених параметрів")

def export_result():
    with open(output_file, "w") as f:
        f.write(label_result.cget("text"))
    log_action("Дія 5: обрано «Експортувати результат у файл»")

def on_close():
    log_action("Дія 6: додаток закрито")
    root.destroy()

# GUI
clear_log()
root = tk.Tk()
root.title("Калькулятор")

tk.Label(root, text="Число 1").pack()
e1 = tk.Entry(root)
e1.pack()

tk.Label(root, text="Число 2").pack()
e2 = tk.Entry(root)
e2.pack()

var = tk.StringVar(value="+")
for op in ["+", "-", "*", "/", "^"]:
    tk.Radiobutton(root, text=op, variable=var, value=op).pack()

tk.Button(root, text="Імпортувати", command=import_data).pack()
tk.Button(root, text="Обчислити", command=calculate).pack()
tk.Button(root, text="Експортувати", command=export_result).pack()

label_result = tk.Label(root, text="")
label_result.pack()

root.protocol("WM_DELETE_WINDOW", on_close)
root.mainloop()