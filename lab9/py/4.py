import tkinter as tk
from collections import deque

class Node:
    def __init__(self, key):
        self.left = None
        self.right = None
        self.key = key

class BST:
    def __init__(self):
        self.root = None

    def insert(self, key):
        if not self.root:
            self.root = Node(key)
            return
        q = deque([self.root])
        while q:
            temp = q.popleft()
            if not temp.left:
                temp.left = Node(key)
                break
            else:
                q.append(temp.left)
            if not temp.right:
                temp.right = Node(key)
                break
            else:
                q.append(temp.right)

    def search(self, key):
        q = deque([self.root])
        while q:
            temp = q.popleft()
            if temp.key == key:
                return True
            if temp.left:
                q.append(temp.left)
            if temp.right:
                q.append(temp.right)
        return False

    def inorder(self, node):
        return self.inorder(node.left) + [node.key] + self.inorder(node.right) if node else []

tree = BST()

def add_node():
    tree.insert(int(entry.get()))
    update_output()

def find_node():
    result.set("Знайдено" if tree.search(int(entry.get())) else "Не знайдено")

def update_output():
    result.set("Обхід: " + str(tree.inorder(tree.root)))

root = tk.Tk()
tk.Label(root, text="Значення:").pack()
entry = tk.Entry(root)
entry.pack()
tk.Button(root, text="Додати", command=add_node).pack()
tk.Button(root, text="Пошук", command=find_node).pack()
result = tk.StringVar()
tk.Label(root, textvariable=result).pack()
root.mainloop()
