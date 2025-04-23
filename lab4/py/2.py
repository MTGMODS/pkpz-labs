# Створення TF_1
with open("TF_1.txt", "w") as f:
    f.write("hello123\ntest4567\nno number\nLine890")

# Видалення цифр і запис у TF_2
with open("TF_1.txt", "r") as f:
    text = f.read()
filtered = ''.join([c for c in text if not c.isdigit()])
lines = [filtered[i:i+10] for i in range(0, len(filtered), 10)]

with open("TF_2.txt", "w") as f:
    for line in lines:
        f.write(line + '\n')

# Вивід TF_2
with open("TF_2.txt", "r") as f:
    for line in f:
        print(line.strip())