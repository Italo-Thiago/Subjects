from functools import reduce

# Function to add two numbers
def add(x, y):
    return x + y

a = [1, 2, 3, 4, 5]
res = reduce(add, a)

print(res) # Output: 15