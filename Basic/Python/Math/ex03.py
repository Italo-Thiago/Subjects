text = "Aprender a utilizar a função max e min em Python, é fundamental para otimizar seus códigos"

words = text.split()

# Devemos usar a key=len, pois ela e um critério para encontrar a maior palavra em termos de números de caracteres
bigger = max(words, key=len)
smaller = min(words, key=len)

print(f"Bigger: {bigger}, Smaller = {smaller}")
'''
sem key=len
Bigger: é, Smaller = Aprender

com key=len
Bigger: fundamental, Smaller = a
'''