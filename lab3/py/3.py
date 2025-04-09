import tkinter as tk

def remove_repeats():
    text = input_box.get("1.0", tk.END)
    words = re.split(r'(\W+)', text)
    result = ""

    for word in words:
        if word.isalpha():
            seen = set()
            unique_word = ''.join([ch for ch in word if not (ch in seen or seen.add(ch))])
            result += unique_word
        else:
            result += word

    output_box.delete("1.0", tk.END)
    output_box.insert(tk.END, result)

import re

root = tk.Tk()
root.title("Видалення повторних літер")

input_box = tk.Text(root, height=5, width=50)
input_box.pack()

tk.Button(root, text="Вилучити повтори", command=remove_repeats).pack()

output_box = tk.Text(root, height=5, width=50)
output_box.pack()

root.mainloop()
