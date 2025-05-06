import tkinter as tk
from tkinter import messagebox
from datetime import datetime

def calculate_time():
    try:
        start_date_str = entry_start_date.get()
        start_time_str = entry_start_time.get()
        end_date_str = entry_end_date.get()
        end_time_str = entry_end_time.get()

        start_datetime = datetime.strptime(start_date_str + " " + start_time_str, "%d%m%Y %H:%M:%S")
        end_datetime = datetime.strptime(end_date_str + " " + end_time_str, "%d%m%Y %H:%M:%S")

        if end_datetime < start_datetime:
            messagebox.showerror("Помилка", "Час повернення менший за час виходу.")
            return

        delta = end_datetime - start_datetime
        total_minutes = int(delta.total_seconds() // 60)
        full_hours = total_minutes // 60

        result_var.set(f"Загальний час: {total_minutes} хвилин\nЦілих годин: {full_hours}")

    except Exception as e:
        messagebox.showerror("Помилка", "Неправильний формат введення. Використовуйте ДДММРРРР та ГГ:ХХ:СС")

# GUI
root = tk.Tk()
root.title("Тривалість маршруту трамваю")
root.geometry("400x300")

tk.Label(root, text="Дата виходу (ДДММРРРР):").pack()
entry_start_date = tk.Entry(root)
entry_start_date.pack()

tk.Label(root, text="Час виходу (ГГ:ХХ:СС):").pack()
entry_start_time = tk.Entry(root)
entry_start_time.pack()

tk.Label(root, text="Дата повернення (ДДММРРРР):").pack()
entry_end_date = tk.Entry(root)
entry_end_date.pack()

tk.Label(root, text="Час повернення (ГГ:ХХ:СС):").pack()
entry_end_time = tk.Entry(root)
entry_end_time.pack()

tk.Button(root, text="Розрахувати", command=calculate_time).pack(pady=10)

result_var = tk.StringVar()
tk.Label(root, textvariable=result_var, fg="blue").pack()

root.mainloop()
