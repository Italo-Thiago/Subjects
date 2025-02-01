'''
Modele uma classe abstrata TesteUnitario com métodos abstratos preparar_ambiente(), executar_teste() e limpar_ambiente(). Crie uma subclasse TesteAPIREST que implemente esses métodos. Justifique por que métodos de setup/teardown são bons candidatos para abstração.
'''
from abc import ABC, abstractmethod

class UnitTesting(ABC):
    @abstractmethod
    def Prepare_Environment(self):
        pass
    
    @abstractmethod
    def Run_Rest(self):
        pass
    
    @abstractmethod
    def Clean_Environment(self):
        pass
    
class API_REST_Test(UnitTesting):
    def __init__(self, name:str = "", endpoints:list = [], environment:str = ""):
        self.name = name;
        self.endpoints = endpoints;
        self.environment = environment;
        
    def Prepare_Environment(self):
        print(f"The name test {self.name} is ready for the environment {self.environment}");

    def Run_Rest(self):
        print(f"Running the {self.name} in the {self.environment} environment with the following endpoints")
        counter = 1;
        for end in self.endpoints:
            print(f"End Point {counter}°: {end}")
            counter += 1;

    def Clean_Environment(self):
        print(f"Cleaning up test {self.name} in environment {self.environment}");

api = API_REST_Test("Login Information", [1, 2, 3, 4], "Development")
api.Prepare_Environment()
api.Run_Rest()
api.Clean_Environment()
