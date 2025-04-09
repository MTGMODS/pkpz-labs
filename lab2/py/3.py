import random

def generate_salary_matrix(rows=10, cols=12, min_val=5000, max_val=25000):
    return [[random.randint(min_val, max_val) for _ in range(cols)] for _ in range(rows)]

def print_matrix(matrix):
    for i, row in enumerate(matrix, 1):
        print(f"Працівник {i:2}: " + " ".join(f"{val:6}" for val in row))

def main():
    matrix = generate_salary_matrix()
    print("Матриця зарплат (10 осіб × 12 місяців):")
    print_matrix(matrix)

    person_index = int(input("\nВведіть номер особи (1–10): ")) - 1
    if 0 <= person_index < 10:
        avg_salary = sum(matrix[person_index]) / 12
        print(f"Середня зарплата за рік для особи №{person_index + 1}: {avg_salary:.2f} грн")
    else:
        print("Неправильний номер особи.")

if __name__ == "__main__":
    main()
