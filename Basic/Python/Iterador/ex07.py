# Any Exemple
# Since all are false, false is returned
print(any([False, False, False, False])) # False

# Here the method will short-circuit at the
# second item (True) and will return True.
print(any([False, True, False, False])) # True

# first (True) and will return True.
print(any([True, False, False, False])) # True

print()

# All Exemple
# Here all the iterables are True so all
# will return True and the same will be printed
print(all([True, True, True, True])) # True

# Here the method will short-circuit at the
# first item (False) and will return False.
print(all([False, True, True, False])) # False

# This statement will return False, as no
# True is found in the iterables
print(all([False, False, False])) # False