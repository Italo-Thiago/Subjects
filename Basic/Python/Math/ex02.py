numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9]
n_and_s = [50, "car", 10, "claymore", 5, "monitor", 100, "universe"]

def print_max_and_min(l:list):
    try:
        print(f"Max = {max(l)}")
        print(f"Min = {min(l)}")
    except TypeError as e:
        print(f"Erro TypeError: {e}")

print_max_and_min(numbers)
print_max_and_min(n_and_s)