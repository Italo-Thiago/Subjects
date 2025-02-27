'''
Crie um sistema simples para gerenciar uma biblioteca. Você deverá implementar classes para representar livros, autores e a própria biblioteca.
'''
# 0. Criar esqueleto usando o pass (Prototipagem rápida)
# 1. Criar a estrutura das classes da mais básica para a mais complexa ↓ (Para usar as classes como argumento)
# 2. Evitar input do usuário (Validação demora)
# 4. Passar informações entre as classes mantendo o principio de responsabilidade única 

class Autores:
    def __init__(self, nome, idade):
        self.nome = nome
        self.idade = idade

    # def autor_esta_registrado(self, autor, lista):
    #     for autor = lista.


class Livros:
    def __init__(self, id, nome, generos, autores:list):
        self.id = id
        self.nome = nome
        self.genero = generos
        self.autores = autores

    def novo_livro(id, nome, genero, autores:list):
        return Livros(id, nome, genero, autores)

    def mostrar_livro(livro):
        nome = livro.nome
        id = livro.id
        generos = livro.generos
        autores = livro.autores

    
class Leitores:
    def __init__(self, id, nome, celular):
        self.id = id
        self.nome = nome
        self.celular = celular

class Biblioteca:
    def __init__(self, livros:list[Livros], leitores:list[Leitores]):
        self.livros = livros
        self.leitores = leitores
       
    def adicionar_livro_biblioteca(self):
        id = int(input(f"Digite o id do livro: "))
        nome = input(f"Digite o nome do livro: ").strip().title()
        genero = input(f"Digite o genero do livro: ").strip().title()
        autores:list = []
        while True:
            escolha = input(f"Deseja adicionar um autor(S = sim, N = não): ").lower().strip()
            if escolha == "s":
                autor = input("Digite o nome do autor: ").strip().title()
                autores.append(autor)
            elif escolha == "n":
                print("Usuário não deseja adicionar mais autores.")
                break
            else:
                print("Tente novamente")
        self.livros.append(Livros.novo_livro(id, nome, genero, autores))
        self.mostrar_livros_da_biblioteca()
     
    def mostrar_livros_da_biblioteca(self):
        for livro in self.livros:
            print(livro.nome)


lucas = Leitores(1, "Lucas", 171171171)
issac = Autores("Issac Asimov", 47)
eu_robo = Livros(1,"Eu Robô", ["Fissão", "Drama"], issac)
fundacao = Livros(2, "Fundação", ["Fissão", "Literatura"], issac)
b = Biblioteca([eu_robo, fundacao], [lucas])
b.adicionar_livro_biblioteca()


