'''
História:
Em uma cidade futurista chamada TechnoCity, robôs autônomos colaboram com humanos para manter a ordem e a eficiência urbana. Engenheiros criaram um sistema para gerenciar as tarefas dos robôs, otimizando a distribuição de funções de transporte, segurança e manutenção.

Descrição do Sistema:
Desenvolva um sistema em Python utilizando Programação Orientada a Objetos para gerenciar robôs e suas tarefas. O sistema deverá possibilitar:

1. Cadastro de robôs com atributos como id, tipo (transporte, segurança, manutenção) e status (ativo/inativo).
2. Criação de tarefas, com atributos como descrição, prioridade e prazo.
3. Atribuição de tarefas aos robôs conforme suas habilidades.
4. Simulação da execução de uma tarefa, com alteração do status do robô e registro do progresso.

Requisitos Técnicos:
1. Crie as classes: Robo, Tarefa e SistemaDeGerenciamento.
2. Implemente métodos para cadastrar, atribuir e executar tarefas.
3. Simule um cenário onde diversos robôs recebem tarefas e acompanhe o status de cada um.
'''


class Robo:
    def __init__(self, id:int, tipo:str, status:bool):
       self.id = id
       self.tipo = tipo
       self.status = status 

class Tarefa:
    def __init__(self, descricao, prioridade, prazo):
        self.descricao = descricao
        self.prioridade = prioridade
        self.prazo = prazo

class Sistema:
    def __init__(self):
        self.robo_tarefa = {}
       
    def mostrar_tarefa_do_robo(self, robo:Robo):
        dic = self.robo_tarefa.keys()
        for i in dic:
            if i == robo.id:
                tarefa = self.robo_tarefa[i]
                print(f"A tarefa e: {tarefa}")
               
    def mostrar_tarefas(self):
        for i, j in self.robo_tarefa.items():
            print(f"key: {i}, value: {j}")

    def atribuir_tarefa(self, robo:Robo, tarefa:Tarefa):
        print(f"Robô com id: {robo.id}, está executando a tarefa: {tarefa.descricao}");
        self.robo_tarefa[robo.id] = tarefa.descricao
        self.mostrar_tarefa_do_robo(robo)

    def remover_tarefa(self, robo:Robo):
        print(f"Removendo tarefa do robo: {robo.id}")
        self.robo_tarefa.pop(robo.id)

    # def atualizar_tarefa(self):

robo = Robo(1,"transporte", True)
transporte = Tarefa("Dirigir carro", "Alta", "Dia todo")
s = Sistema()
s.atribuir_tarefa(robo,transporte)
s.mostrar_tarefas()
s.remover_tarefa(robo)
s.mostrar_tarefas()