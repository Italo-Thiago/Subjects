'''
Descrição: Proponha uma atividade em que o programador crie um iterador customizado para percorrer uma coleção de elementos (por exemplo, uma lista de tarefas). O iterador deve:
    
1. Seguir uma ordem específica definida pelo programador.
2. Implementar os métodos essenciais para funcionar corretamente em um laço de repetição.
'''

class Iterador:
    def __init__(self, number):
        self.number = number
    
    def __iter__(self):
        self.n = self.number 
        return self

    def __next__(self):
        x = self.n
        self.n += self.number 
        return x

# def create_iterable(max:int):
#     temp = []
#     i = 0
#     while i < max:
#         temp.append(i)
#         i += 1
#     return temp

def iteration(Iterador:Iterador, max:int):
    temp = []
    i = 0
    while i < max:
        l = next(Iterador)
        temp.append(l)
        i += 1
    print(temp)

# iterable = create_iterable(50)
# print(iterable)
# print()
Two = Iterador(2)
two = iter(Two)
iteration(two, 10)
print()
Ten = Iterador(10)
ten = iter(Ten)
iteration(ten, 100)