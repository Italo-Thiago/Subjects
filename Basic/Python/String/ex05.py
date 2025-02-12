'''
Resumo: Reformatar um nome completo invertendo a ordem das palavras.
Descrição:
Crie uma função que receba um nome completo (formato: primeiro nome, nomes do meio e último nome) e retorne uma string com a ordem invertida (último nome, nomes do meio e primeiro nome). A função deve também garantir que cada palavra esteja com a primeira letra em maiúscula e o restante em minúsculas.
'''
# TODO: Refatorar o método construtor deve receber o nome completo

class Name:
    def __init__(self, name:str):
        self.name = name

    def invert_name(self):
        words = self.name.title().split()
        inverted = words[::-1]
        invert = ' '.join(inverted) 
        print(invert)

nome = Name("alemão du Gás tchêtchetcheeee")
nome.invert_name()
