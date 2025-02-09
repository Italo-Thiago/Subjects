# initialize an empty list
a = []

# Adding 10 to end of list
a.append(10)
print("After append(10): ", a)

# Inserting 5 at index 0
a.insert(0, 5)
print("After insert(0, 5): ", a)

# Adding multiple elements [15, 20, 25] at the end
a.extend([15, 20, 25])
print("After extend([15, 20, 25]): ", a)

numeros = [5, 10, 5]
print(numeros)
numeros.extend([25, 15, 20])
print(numeros)