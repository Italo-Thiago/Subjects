'''
Uma aplicação precisa suportar múltiplos métodos de autenticação (ex: AutenticacaoSenha, AutenticacaoBiometrica). Crie uma classe abstrata PluginAutenticacao com métodos abstratos autenticar() e validar_permissao(). Explique como a classe abstrata garante a consistência entre diferentes plugins.
'''
from abc import ABC, abstractmethod

class Authentication_Plugin(ABC):
    @abstractmethod
    def __init__(self):
        pass

    @abstractmethod
    def Authenticate(self):
        pass

    @abstractmethod
    def Validate_Permission(self):
        pass
    
class Authentication_Password(Authentication_Plugin):
    def __init__(self, password:str):
        self.password = password;
        
    def Authenticate(self):
        if self.password == 12345:
            print("Permission accepted")
        else:
            print("Permission denied")

    def Validate_Permission(self):
        print("User permission")
    
class Biometric_Authentication(Authentication_Plugin):
    def __init__(self, finger:int):
        self.finger = finger

    def Authenticate(self):
        if self.finger == 171171:
            print("Permission accepted")
        else:
            print("Permission denied")

    def Validate_Permission(self):
        print("Administrator permission")
        
password = Authentication_Password(12345)
password.Authenticate()
password.Validate_Permission()
print()
finger = Biometric_Authentication(171171)
finger.Authenticate()
finger.Validate_Permission()