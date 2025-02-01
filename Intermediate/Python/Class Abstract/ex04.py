'''
Defina uma classe abstrata DispositivoIoT com métodos abstratos ler_sensor() e atualizar_firmware(), e uma propriedade abstrata status_conexao. Crie uma subclasse TermostatoInteligente que implemente todos os membros abstratos. Justifique o uso de propriedades abstratas.
'''
from abc import ABC, abstractmethod

class IoT_Device(ABC):
    @property
    @abstractmethod
    def __init__(self, connection_status:str):
        self.connection_status = connection_status;
        
    @abstractmethod
    def Read_Sensor(self):
        pass

    @abstractmethod
    def Update_Firmware(self):
        pass

class Smart_Thermostat(IoT_Device):
    def __init__(self, connection_status:str, sensors:dict, firmware:float):
        self.connection_status = connection_status;
        self.sensors = sensors;
        self.firmware = firmware;
        
    def Read_Sensor(self):  
        counter = 1;
        print("Reading the sensor...")
        for sensor, status in self.sensors.items():
            print(f"Sensor {counter}°: {sensor}, {status}")
            counter += 1;
    
    def Update_Firmware(self):
        print(f"Current firmware version: {self.firmware}")
        print(f"New version: 2.0")
        if self.firmware == 2.0:
            print("Firmware in the latest version")
        else:
            self.firmware == 2.0;
            print("Firmware updated")
            
thermostat1 = Smart_Thermostat("OK", {"light": "OK", "sound": "OFF", "temperature": "OK"}, 1.8);
thermostat2 = Smart_Thermostat("OFF", {"light": "OFF", "sound": "OFF", "temperature": "OK"}, 2.0);

thermostat1.Read_Sensor()
thermostat1.Update_Firmware()

thermostat2.Read_Sensor()
thermostat2.Update_Firmware()