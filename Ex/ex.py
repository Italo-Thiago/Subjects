'''
Exemplo de uso do return 
'''
# Múltiplos valores de retorno
def fun_multi():
    name = "Alice"
    age = 30
    return name, age

name, age = fun_multi();
print(name)
print(age)

# Retornando uma lista
def fun_list(number):
    return [number**2, number**3]

res = fun_list(3)
print(res)

# Retornando outra função
def fun_1(message):
    def fun_2():
        # Using the outer function's message
        return f"Message: {message}"
    return fun_2

# Getting the inner function
fun_3 = fun_1("Hello, World!");

# Calling the inner functions
print(fun_3())
