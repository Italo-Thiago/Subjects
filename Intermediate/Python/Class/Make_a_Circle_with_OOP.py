'''
- Sua tarefa é criar um construtor de Círculo que cria um círculo com um raio fornecido por um argumento. 

- Os círculos construídos devem ter dois métodos getArea() (PI * r^2) e getPerimeter() (2 * PI * r) que fornecem as respectivas áreas e perímetros(circunferência).

- Arredonde os resultados para o número inteiro mais próximo
'''
from math import pi

class Rectangle:
	def __init__(self, sideA=0, sideB=0):
		self.sideA = sideA
		self.sideB = sideB

	def getArea(self):
		return self.sideA * self.sideB
  
	def getPerimeter(self):
		return 2 * (self.sideA + self.sideB)

class Circle:
    def __init__(self, radius):
        self.radius = radius;
        
    def getArea(self):
        return pi * self.radius ** 2
    
    def getPerimeter(self):
        return 2 * pi * self.radius

circy = Circle(11)
circy.getArea
    
# Should return 380.132711084365


