from typing import Iterator

def float_range(start: float, stop: float, step: float) -> Iterator[float]:
    if step == 0:
        raise ValueError("Step cannot be 0.")
    current = start
    if step > 0:
        while current < stop:
            yield round(current, 10)
            current += step
    else:
        while current > stop:
            yield round(current, 10)
            current += step

if __name__ == "__main__":
    start = float(input("Початок: "))
    stop = float(input("Кінець: "))
    step = float(input("Крок: "))
    print("Результат:", list(float_range(start, stop, step)))
