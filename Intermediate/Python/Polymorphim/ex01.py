'''
Crie um sistema onde diferentes animais (ex: Cachorro, Gato, Vaca) emitem sons distintos. Use polimorfismo para garantir que cada animal tenha um método emitir_som() que retorna uma string com o som correspondente. Crie uma função que aceite uma lista de animais e faça todos emitirem seus sons.
'''
class Animal:
    def Make_sound(self):
        pass

class Dog(Animal):
    def Make_sound(self):
        print("Ohhh")

class Cat(Animal):
    def Make_sound(self):
        print("Miau")

class Cow(Animal):
    def Make_sound(self):
        print("Muuuuu")

dog = Dog()
dog.Make_sound()

cat = Cat()
cat.Make_sound()

cow = Cow()
cow.Make_sound()