import re
import tkinter as tk
from tkinter import messagebox

def extract_math_symbols(text):
    return re.findall(r'[+\-*/=<>^]', text)

def update_output():
    text = input_box.get("1.0", tk.END)
    symbols = extract_math_symbols(text)
    result_label.config(text=f"Знайдено символів: {len(symbols)}\n{symbols}")

def delete_symbol():
    text = input_box.get("1.0", tk.END)
    to_delete = entry_delete.get()
    if not to_delete:
        messagebox.showinfo("Помилка", "Введіть символ для видалення.")
        return
    new_text = text.replace(to_delete, "")
    input_box.delete("1.0", tk.END)
    input_box.insert(tk.END, new_text)
    update_output()

def replace_symbol():
    text = input_box.get("1.0", tk.END)
    old = entry_old.get()
    new = entry_new.get()
    if not old:
        messagebox.showinfo("Помилка", "Введіть символ для заміни.")
        return
    new_text = text.replace(old, new)
    input_box.delete("1.0", tk.END)
    input_box.insert(tk.END, new_text)
    update_output()

root = tk.Tk()
root.title("Робота з математичними символами")

input_box = tk.Text(root, height=5, width=50)
input_box.pack()

tk.Button(root, text="Знайти символи", command=update_output).pack()

result_label = tk.Label(root, text="")
result_label.pack()

entry_delete = tk.Entry(root)
entry_delete.pack()
tk.Button(root, text="Видалити символ", command=delete_symbol).pack()

entry_old = tk.Entry(root)
entry_new = tk.Entry(root)
entry_old.pack()
entry_new.pack()
tk.Button(root, text="Замінити символ", command=replace_symbol).pack()

root.mainloop()
