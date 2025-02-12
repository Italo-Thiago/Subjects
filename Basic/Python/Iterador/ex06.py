# All keys of dictionary are true
d = {1: "Hello", 2: "Hi"}
print(any(d))

# All keys of dictionary are false
d = {0: "Hello", False: "Hi"}
print(any(d))

# Some keys of dictionary are True while others are False
d = {0: "Salut", 1: "Hello", 2: "Hi"}
print(any(d))

# Empty dictionary
d = {}
print(any(d))
'''
True
False
True
False
'''