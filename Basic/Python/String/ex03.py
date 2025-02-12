'''
Resumo: Criar uma função que identifique palavras que começam com vogal em um texto.
Descrição:
Desenvolva uma função que receba uma string contendo um parágrafo e retorne uma lista com todas as palavras (sem repetições) que iniciam com uma vogal, considerando as variações de caixa (maiúsculas/minúsculas).
'''
# Transformar o paragrafo em lista
# Deixar tudo em minúsculo
# Verificar se inicia com vogal
# Verificar se tem repetição
# Retornar a lista

def char_remove(old:str, to_remove):
    new_string:str = old.strip().lower()
    for x in to_remove:
        new_string = new_string.replace(x, '')
    return new_string

def words_with_vowels(strings:str):
    new_string = char_remove(strings, '.,(#”\“)')
    words = new_string.split()
    vowels = ['a', 'e', 'i', 'o', 'u', 'à', 'á', 'ã', 'è', 'é', 'í', 'ì', 'ó', 'ò', 'õ', 'ú', 'ü', 'ù', 'â', 'ê', 'î', 'ô', 'û']
    words_with_vowels = []
    for word in words:
        if word[0] in vowels and word not in words_with_vowels:
            words_with_vowels.append(word)
    # for word in words_with_vowels:
    print(words_with_vowels)

words_with_vowels("Neste exemplo, a função join é utilizada para unir os nomes da lista nomes, separando-os por vírgula. O resultado é a string “João,Maria,Pedro”. Perceba como a função join facilita a tarefa de unir os elementos da lista em uma única string.")
    