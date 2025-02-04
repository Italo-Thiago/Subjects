'''
Exemplo de função usando *args e **kwargs
'''

def fun_arg(*args):
    for arg in args:
        print(arg)

def fun_kwar(**kwargs):
    for k, val in kwargs.items():
        print(f"{k}: {val}");

# Calling the function with multiple arguments
fun_arg(1, 2, 3, 4, 5,)

# Calling the function with keyword arguments
fun_kwar(name = "Alice", age = 30, city = "New York")