def filter_even_numbers(nums: list[int]) -> list[int]:
    return [num for num in nums if num % 2 == 0]

if __name__ == "__main__":
    nums = list(map(int, input("Введіть числа через пробіл: ").split()))
    print("Парні числа:", filter_even_numbers(nums))
