'''
Crie uma classe abstrata APICliente com métodos abstratos enviar_requisicao() e tratar_resposta(), e um método concreto log_conexao(). Defina uma subclasse ClienteHTTP que implemente os métodos abstratos. Descreva como a classe abstrata padroniza o tratamento de logs.
'''
from abc import ABC, abstractmethod

class API_Client(ABC):
    @abstractmethod
    def __init__(self, response:str, log:str):
        self.response = response
        self.log = log;
        
    @abstractmethod
    def Send_Request(self):
        pass
    
    @abstractmethod
    def Handle_Request(self):
        pass
    
    def Connection_Log(self):
        print(f"Showing connection log {self.log}");
        
class Client_HTTP(API_Client):
    def __init__(self, response:str, log:str, request:str):
        super().__init__(response, log)
        self.request = request;

    def Send_Request(self):
        print(f"Sending request: {self.request}")

    def Handle_Request(self):
        print(f"Treating response {self.response}")
        if self.response == 200:
            print(f"Well adjustable connection");
        else:
            print(f"Connection unsuccessful");
        
    def Connection_Log(self):
        return super().Connection_Log()

client1 = Client_HTTP(400, "Bad Request", "GET");
client1.Send_Request()
client1.Handle_Request()
client1.Connection_Log()
