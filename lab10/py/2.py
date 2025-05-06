class Countdown:
    def __init__(self, start: int):
        self.current = start if start >= 0 else -1

    def __iter__(self):
        return self

    def __next__(self):
        if self.current < 0:
            raise StopIteration
        value = self.current
        self.current -= 1
        return value

if __name__ == "__main__":
    start = int(input("Введіть початкове число: "))
    for number in Countdown(start):
        print(number)
