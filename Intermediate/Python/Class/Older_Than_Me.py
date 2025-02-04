'''
Crie um método na classe Pessoa que retorne como a idade de outra pessoa se compara

dados os objetos p1, p2 e p3, que serão inicializados com os atributos nome e idade, retorne uma frase no seguinte formato: 
{outra pessoa} é {mais velha que / mais nova que / da mesma idade que} eu
'''

class Person:
    def __init__(self, name:str, age:int):
        self.name = name;
        self.age = age;
        
    def compare_age(self, person):
        if self.age == person.age:
            print("{} is the same age as me.".format(person.name));
        elif self.age > person.age:
            print("{} is younger than me.".format(person.name))
        elif self.age < person.age:
            print("{} is older than me.".format(person.name))
            
p1 = Person("Samuel", 24)
p2 = Person("Joel", 36)
p3 = Person("Lily", 24)

p1.compare_age(p2) 

p2.compare_age(p1)

p1.compare_age(p3) 