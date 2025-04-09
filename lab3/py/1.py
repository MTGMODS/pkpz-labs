import tkinter as tk
from tkinter import messagebox

def count_at_symbols():
    text = input_entry.get()
    count = text.count('@')
    result_label.config(text=f"Символ '@' зустрічається {count} раз(и)")

root = tk.Tk()
root.title("Лабораторна 3 – Підрахунок '@'")
root.geometry("400x200")

tk.Label(root, text="Введіть рядок:").pack(pady=10)
input_entry = tk.Entry(root, width=40)
input_entry.pack()

count_button = tk.Button(root, text="Порахувати '@'", command=count_at_symbols)
count_button.pack(pady=10)

result_label = tk.Label(root, text="")
result_label.pack(pady=10)

root.mainloop()
