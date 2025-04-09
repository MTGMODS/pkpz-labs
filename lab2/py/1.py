def input_array():
    return list(map(int, input("Введіть елементи масиву через пробіл: ").split()))

def swap_positives(arr):
    positives = [i for i, x in enumerate(arr) if x >= 0]
    n = len(positives)
    for i in range(n // 2):
        a, b = positives[i], positives[n - 1 - i]
        arr[a], arr[b] = arr[b], arr[a]
    return arr

def main():
    arr = input_array()
    print("Масив до обробки:", arr)
    arr = swap_positives(arr)
    print("Масив після обробки:", arr)

if __name__ == "__main__":
    main()