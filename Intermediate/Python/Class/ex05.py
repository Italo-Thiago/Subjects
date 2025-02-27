'''
Modelar classes para representar Paciente, Médico, Consulta e Agenda.
Utilizar herança para diferenciar especialidades dos médicos (ex.: Clínico Geral, Cardiologista, Pediatra) ou tipos de consultas (ex.: Consulta Presencial, Teleconsulta).
Aplicar composição para associar consultas a pacientes e médicos.
Implementar métodos de validação para agendamento de consultas, evitando conflitos de horário e permitindo cancelamentos e reagendamentos.
'''

class Paciente:
    def __init__(self, nome, idade, doenca):
        self.nome = nome
        self.idade = idade
        self.doenca = doenca

class Medico:
    def __init__(self, id, nome, disponivel):
        self.id = id
        self.nome = nome
        self.disponivel = disponivel

# class ClinicoGeral(Medico):
#     pass

# class Cardiologista(Medico):
#     pass

# class Pediatra(Medico):
#     pass

class Consulta:
    def __init__(self, id, data:int, paciente, medico):
        self.id = id
        self.data = data
        self.paciente = paciente
        self.medico = medico

    def mostrar_consulta(self):
        mensagem = f"Id: {self.id}, Data {self.data}, Paciente: {self.paciente.nome}, Médico: {self.medico.nome}"
        print(mensagem)

    def mudar_data(self, nova_data):
        self.data = nova_data

# class ConsultaPresencial(Consulta):
#     pass

# class Teleconsulta(Consulta):
#     pass

class Agenda:
    def __init__(self, consultas:list[Consulta]):
        self.consultas = consultas
        # self.consultas = consultas if isinstance(consultas, list) else [consultas]


    def mostrar_consultas(self):
        print("Mostrando consultas")
        for c in self.consultas:
            c.mostrar_consulta()

    def cadastrar_consulta(self, id_consulta, data, paciente, medico):
        c = Consulta(id_consulta, data, paciente, medico)
        self.consultas.append(c)

    # def cancelar_consulta(self, id_consulta
    #     self.consultas.append(c)

    def reagendar_consulta(self, nova_data, consulta:Consulta):
        if nova_data <= consulta.data:
            print("Não foi possível remarcar")
        else:
            consulta.mudar_data(nova_data)
        consulta.mostrar_consulta()


maria = Paciente("Maria", 20, "Dor nas vista")
alex = Paciente("Alex", 30, "Pilastina")

pedro = Medico(1, "Pedro", True)

c = Consulta(1, 1022000, alex, pedro)
c2 = Consulta(2, 2022000, maria, pedro)

a = Agenda([c, c2])
a.mostrar_consultas()
a.reagendar_consulta(14022000, c)
