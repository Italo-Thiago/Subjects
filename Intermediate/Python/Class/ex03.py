'''
- Modelar classes para Hotel, Quarto, Reserva e Hóspede.
- Utilizar herança para definir diferentes tipos de quartos (ex.: Suite, Quarto Simples), cada um com atributos e serviços específicos.
- Aplicar composição para associar reservas aos hóspedes e aos quartos.
- Implementar métodos de verificação de disponibilidade, cálculo do custo da estadia e gerenciamento de reservas (incluindo cancelamentos).

Passo I
Conteúdo: Estruture as classes definindo atributos como número e tipo de quarto, preço, dados do hóspede (nome, contato) e datas de reserva.

Passo II
Resumo: Implementação da herança para diferenciar tipos de quartos.
Conteúdo: Crie subclasses para cada tipo de quarto, adicionando características específicas, como serviços inclusos ou tarifas diferenciadas.

Passo III
Resumo: Uso da composição para associar reservas aos hóspedes e quartos.
Conteúdo: Modele a relação onde uma reserva vincula um hóspede a um quarto, considerando a disponibilidade e o período de estadia.

Passo IV
Resumo: Desenvolvimento de funcionalidades integradas.
Conteúdo: Implemente métodos que verifiquem a disponibilidade dos quartos, calculem automaticamente o valor da estadia com base no tipo de quarto e no período, e gerenciem alterações ou cancelamentos de reservas.
'''
# Colocar classe mais importante por último
# Use return para passar valores entre as classes de cima para baixo

class Hospede:
    def __init__(self, nome, contato):
        self.nome = nome
        self.contato = contato

class Servico:
    def __init__(self, nome, valor):
        self.nome = nome
        self.valor = valor

    def adicionar_servico(self, lista, nome, valor):
        return lista.append(Servico(nome, valor))
    
    def remover_servico(self, lista:list, servico):
        return lista.remove(servico)


class Quarto:
    def __init__(self, hospede:Hospede, servicos:list[Servico]):
        self.hospede = hospede
        self.servicos = servicos

    def servico_quarto(self):
        pass

class Suite(Quarto):
    def __init__(self, hospede, servicos):
        super().__init__(hospede, servicos)

    def servico_quarto(self, opcoes:list):
        if opcoes == []:
            return f"Nenhuma opção escolhida"
        for opcao in opcoes:
            if opcao == 1:
                return f"Adicionado comida as serviços" 

class Q_Simples(Quarto):
    def __init__(self, hospede, servicos):
        super().__init__(hospede, servicos)

class Reserva:
    def __init__(self, id, hospede:Hospede, quarto, inicio, termino):
        self.id = id
        self.hospede = hospede
        self.quarto = quarto
        self.inicio = inicio
        self.termino = termino

class Hotel:
    def __init__(self, nome, n_quartos, quartos):
        self.nome = nome
        self.n_quartos = n_quartos
        self.quartos = quartos

maria = Hospede("Maria das Dores", 171171171)
dolores = Hospede("Dolores", 101110001)

suite_maria = Suite(maria, 200, True)

