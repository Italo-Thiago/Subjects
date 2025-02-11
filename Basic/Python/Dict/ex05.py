'''
Descrição: Imagine um dicionário onde as chaves são nomes de produtos e os valores são seus respectivos preços. Crie um conjunto de atividades que:

1. Calcule o total gasto em uma compra composta por diversos produtos.
2. Identifique qual é o produto mais caro e qual o mais barato.
3. Atualize o preço de um produto específico.
'''

def create_stock(n_of_product:int):
    i = 0
    products = {}
    while i < n_of_product:
        name = input("Enter the product name: ") 
        value = float(input("Enter the product price: "))
        products[name] = value
        i += 1
    return products
    
def show_stock(stock:dict):
    for key, value in stock.items():
        print(f"key: {key} \tvalue: R${value}")

def max_and_min_price(stock:dict):
    p_max = max(stock, key=stock.get)
    p_min = min(stock, key=stock.get)
    print(p_max)
    print(p_min)


stock1 = create_stock(3)
show_stock(stock1)
max_and_min_price(stock1)
