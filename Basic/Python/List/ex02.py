a = [10, 20, 30, 40, 50]

# Remove the first occurrence of 30
a.remove(30)
print("After remove(30): ", a)

# Removes the element at index 1 (20)
popped_val = a.pop(1)
print("Popped element:", popped_val)
print("After pop(1): ", a)

# Deletes the first element (10)
del a[0]
print("After del a[0]: ", a)

number = [5, 10, 1, 3, 9];
print(number); # [5, 10, 1, 3, 9]
number.remove(5)
print(number); # [10, 1, 3, 9]

number = [5, 10, 1, 3, 9];
print(number); # [5, 10, 1, 3, 9]
del number[0:2]
print(number); # [1, 3, 9]