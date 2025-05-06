import tkinter as tk


vertices = ['a', 'b', 'c', 'd', 'e', 'f']
n = len(vertices)


edges = [
    ('a', 'b'),
    ('a', 'c'),
    ('a', 'e'),
    ('b', 'a'),
    ('b', 'c'),
    ('b', 'f'),
    ('c', 'f'),
    ('e', 'd'),
    ('e', 'f'),
    ('f', 'd'),
]

# Індекси вершин
vertex_indices = {v: i for i, v in enumerate(vertices)}


def get_adjacency_matrix():
    matrix = [[0] * n for _ in range(n)]
    for u, v in edges:
        matrix[vertex_indices[u]][vertex_indices[v]] = 1
    return matrix


def get_incidence_matrix():
    m = len(edges)
    matrix = [[0] * m for _ in range(n)]
    for i, (u, v) in enumerate(edges):
        matrix[vertex_indices[u]][i] = -1
        matrix[vertex_indices[v]][i] = 1
    return matrix


def display_matrix(matrix, text_widget, is_incidence=False):
    text_widget.delete(1.0, tk.END)
    if is_incidence:
        headers = [f"e{i+1}" for i in range(len(matrix[0]))]
    else:
        headers = vertices
    text_widget.insert(tk.END, "    " + "  ".join(headers) + "\n")
    for i, row in enumerate(matrix):
        row_str = "  ".join(f"{val:2}" for val in row)
        text_widget.insert(tk.END, f"{vertices[i]}  {row_str}\n")


root = tk.Tk()
root.title("Граф: Матриця суміжності та інцидентності")


frame = tk.Frame(root)
frame.pack(padx=10, pady=10)

adj_text = tk.Text(frame, height=10, width=40)
adj_text.grid(row=1, column=0, padx=10)
inc_text = tk.Text(frame, height=10, width=60)
inc_text.grid(row=1, column=1, padx=10)

btn = tk.Button(root, text="Показати матриці", command=lambda: [
    display_matrix(get_adjacency_matrix(), adj_text),
    display_matrix(get_incidence_matrix(), inc_text, is_incidence=True)
])
btn.pack(pady=10)


root.mainloop()
