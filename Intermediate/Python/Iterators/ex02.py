# define a list
l = [1, 2, 3]
# create list_iterator
l_iter = iter(l)

while True:
    # item will be "end" if iteration is complete
    item = next(l_iter, "end")
    if item == "end":
        break
    print(item)