# We used the build-in int function to convert each string in the list s into an integer.
# The map() function takes cares of applying int() to every element
s = ['1', '2', '3', '4']
res = map(int, s)
print(list(res))