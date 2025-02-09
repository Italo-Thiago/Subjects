'''
Dada uma lista de números, some repetidamente pares adjacentes de números até que reste apenas um número.
'''
def total(arr):
    i = 0
    soma = 0
    while True:
        # enquanto índice 
        if i < len(arr) - 1:
            soma = arr[i] + arr[i + 1]
            i += 1
        else:
            break
    return soma

total1 = [1,2,3,4,5]
print(total(total1))