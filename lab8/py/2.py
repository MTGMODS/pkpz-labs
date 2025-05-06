import tkinter as tk
from tkinter import messagebox
from collections import namedtuple


Team = namedtuple('Team', ['name', 'score', 'coach', 'city'])


teams = [
    Team("Tigers", 45, "Shevchenko", "Kyiv"),
    Team("Wolves", 38, "Petrenko", "Lviv"),
    Team("Eagles", 52, "Tkachenko", "Odesa"),
    Team("Bulls", 33, "Ivanov", "Kharkiv"),
    Team("Sharks", 29, "Bondarenko", "Dnipro"),
    Team("Lions", 47, "Kovalenko", "Zaporizhzhia"),
    Team("Panthers", 40, "Melnyk", "Vinnytsia")
]

def tourney(team_list):
    scores = [team.score for team in team_list]
    avg = sum(scores) / len(scores)
    failed = [team.name for team in team_list if team.score < avg]
    return avg, failed

def show_results():
    avg, failed = tourney(teams)
    result_text.set(f"Середній бал: {avg:.2f}\nНе пройшли: {', '.join(failed)}")

def update_scores():
    try:
        new_scores = list(map(int, entry_scores.get().split()))
        if len(new_scores) != 7:
            raise ValueError
    except ValueError:
        messagebox.showerror("Помилка", "Введіть рівно 7 цілих чисел через пробіл!")
        return

    global teams
    teams = [team._replace(score=new_scores[i]) for i, team in enumerate(teams)]
    show_results()

# GUI
root = tk.Tk()
root.title("Турнір команд")

frame = tk.Frame(root, padx=10, pady=10)
frame.pack()

label_title = tk.Label(frame, text="Турнір команд", font=("Arial", 16))
label_title.pack()

btn_show = tk.Button(frame, text="Показати результати", command=show_results)
btn_show.pack(pady=5)

entry_scores = tk.Entry(frame, width=50)
entry_scores.insert(0, "65 62 70 58 55 66 60")
entry_scores.pack()

btn_update = tk.Button(frame, text="Оновити бали", command=update_scores)
btn_update.pack(pady=5)

result_text = tk.StringVar()
label_result = tk.Label(frame, textvariable=result_text, justify="left")
label_result.pack(pady=5)

root.mainloop()
