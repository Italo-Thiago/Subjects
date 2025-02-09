'''
Exercício 2: Fila de Impressão
Em um sistema de fila de impressão, os documentos são adicionados em sequência. Quando um documento é impresso, ele é removido da fila. Como você garantiria que o primeiro documento da fila seja sempre removido após a impressão?
'''

def print_queue(p_list:list):
    printed_items = []
    for item in p_list:
        print(f"Imprimindo item: {item}")
        # adiciona a lista de itens impressos
        printed_items.append(item)
        # remove o item da lista
    
    i = 0;
    while i < len(p_list):
        del p_list[i]

    return printed_items

print_list = ["cat photo", "word document", "baby photo"]
empty_list = []

empty_list = print_queue(print_list)
print(f"Lista de itens já impressos: {empty_list}")
print(f"Lista de itens para impressão:  {print_list}")
      
        
