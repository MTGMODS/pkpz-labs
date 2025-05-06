import tkinter as tk
import random

main = ["Петренко", "Сидоренко", "Коваленко", "Шевченко", "Гаврилюк"]
reserve = ["Іванов", "Мельник", "Бондар", "Ткаченко", "Кравець"]

def substitute():
    k = int(entry_k.get())
    n = int(entry_n.get()) % len(reserve)
    sub = reserve[n]
    indexes = random.sample(range(len(main)), k)
    for i in indexes:
        main[i] = sub
    output_var.set("Новий склад: " + ", ".join(main))

root = tk.Tk()
root.title("Футбольна заміна")
tk.Label(root, text="k (кількість замін):").pack()
entry_k = tk.Entry(root)
entry_k.pack()
tk.Label(root, text="n (номер запасного):").pack()
entry_n = tk.Entry(root)
entry_n.pack()
tk.Button(root, text="Замінити", command=substitute).pack()
output_var = tk.StringVar()
tk.Label(root, textvariable=output_var).pack()
root.mainloop()
