class Stool:
    def __init__(self, height, quality, wood_color):
        self.height = height
        self.quality = quality
        self.wood_color = wood_color

    def wood_quantity(self):
        if self.quality == "low":
            return 4 * self.height + 12
        else:
            return 5 * self.height + 14

    def cost(self):
        d = self.wood_quantity()
        if self.quality == "low":
            return d * 2
        elif self.quality == "medium":
            return d * 3
        else:
            return d * 4

    def info(self):
        return f"Height: {self.height} cm, Quality: {self.quality}, Wood Quantity: {self.wood_quantity()} units, Cost: {self.cost()}"

class Chair(Stool):
    def __init__(self, height, quality, wood_color, backrest_height):
        super().__init__(height, quality, wood_color)
        self.backrest_height = backrest_height

    def wood_quantity(self):
        d = super().wood_quantity()
        return d + self.backrest_height

    def cost(self):
        d = self.wood_quantity()
        return d * 4.5

class Table(Stool):
    def __init__(self, height, quality, wood_color, width):
        super().__init__(height, quality, wood_color)
        self.width = width

    def wood_quantity(self):
        d = super().wood_quantity()
        return d + self.width

    def cost(self):
        d = self.wood_quantity()
        return d * 10


# Приклад використання
stool = Stool(40, "low", "brown")
chair = Chair(40, "medium", "brown", 50)
table = Table(80, "high", "light", 120)

print(stool.info())
print(chair.info())
print(table.info())
