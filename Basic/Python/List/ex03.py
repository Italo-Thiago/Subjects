'''
Exercício 1: Lista de Compras Dinâmica
Você está desenvolvendo um sistema de lista de compras. O usuário deve adicionar itens à lista, mas se ele digitar "arroz", o item deve ser inserido imediatamente após o primeiro item da lista, mesmo que a lista esteja vazia inicialmente. Como você implementaria essa lógica?
'''

def adicionar_item(shop:list):
    new_item = input("Digite o item da lista: ").lower().strip(',')
    if new_item == "arroz":
        if len(shop) < 2:
            shop.append(new_item)
        else:
            shop.insert(2, new_item)
    else:
        shop.append(new_item)
    
def mostrar_itens(shop:list):
    for item in shop:
        print(item)
      
shopping_list = ["beans", "milk", "coffee"];
adicionar_item(shopping_list)
mostrar_itens(shopping_list)

empty_list = [];
adicionar_item(empty_list)
adicionar_item(empty_list)
adicionar_item(empty_list)
mostrar_itens(empty_list)


       