# if 
a = [1, 2, 3, 4, 5]
res = [n for n in a if n % 2 == 0]
print(res)

# if-else
res2 = ["Even" if n % 2 == 0 else "Odd" for n in a]
print(res2)

# if-else nested
res3 = ['Divisible by 2' if n % 2 == 0 else 'Divisible by 3' if n % 3 == 0 else 'Other' for n in a]
print(res3)