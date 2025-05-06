import tkinter as tk
from tkinter import messagebox

class Transport:
    def __init__(self, brand, max_speed, num_wheels):
        self.brand = brand
        self.max_speed = max_speed
        self.num_wheels = num_wheels

    def show(self):
        return f"Brand: {self.brand}\nMax Speed: {self.max_speed} km/h\nWheels: {self.num_wheels}"

class Car(Transport):
    def __init__(self, brand, max_speed, num_wheels, fuel_type):
        super().__init__(brand, max_speed, num_wheels)
        self.fuel_type = fuel_type

    def show(self):
        return f"{super().show()}\nFuel Type: {self.fuel_type}"

class Train(Transport):
    def __init__(self, brand, max_speed, num_wheels, num_cars):
        super().__init__(brand, max_speed, num_wheels)
        self.num_cars = num_cars

    def show(self):
        return f"{super().show()}\nNumber of Cars: {self.num_cars}"

class Express(Train):
    def __init__(self, brand, max_speed, num_wheels, num_cars, route):
        super().__init__(brand, max_speed, num_wheels, num_cars)
        self.route = route

    def show(self):
        return f"{super().show()}\nRoute: {self.route}"


def show_transport():
    car = Car("Tesla", 250, 4, "Electric")
    train = Train("Siemens", 300, 16, 12)
    express = Express("Bombardier", 350, 16, 10, "Kyiv to Lviv")
    messagebox.showinfo("Transport Info", car.show() + "\n\n" + train.show() + "\n\n" + express.show())


root = tk.Tk()
root.title("Transport Info")

btnShow = tk.Button(root, text="Show Transport Info", command=show_transport)
btnShow.pack(pady=20)

root.mainloop()
