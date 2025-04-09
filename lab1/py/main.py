import random

def is_inside_shaded_area(x, y, R):
    in_quarter_circle = (x >= 0) and (y >= 0) and (x**2 + y**2 <= R**2)
    in_triangle = (x <= 0) and (y <= 0) and (y >= -x - R)
    on_boundary = (
        (x >= 0 and y >= 0 and abs(x**2 + y**2 - R**2) < 1e-9) or
        (x <= 0 and y <= 0 and abs(y + x + R) < 1e-9)
    )
    return in_quarter_circle or in_triangle or on_boundary

def main():
    R = float(input("Введіть R: "))
    print("\n| № пострілу | Координати пострілу | Результат |")
    print("-" * 40)

    for i in range(1, 11):
        x = random.uniform(-R, R)
        y = random.uniform(-R, R)
        result = "потрапив в мішень" if is_inside_shaded_area(x, y, R) else "мішень не ушкоджена"
        print(f"| {i:9} | ({x:6.2f}, {y:6.2f}) | {result} |")

if __name__ == "__main__":
    main()
