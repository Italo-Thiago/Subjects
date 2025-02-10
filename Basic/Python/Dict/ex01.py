'''
Uma loja precisa atualizar seu estoque. Ao final do dia, novos produtos chegam e devem ser adicionados à lista de estoque. Produtos com quantidade zero devem ser removidos. Como você adicionaria os novos itens e removeria os esgotados?
'''

def add_stock(stock:dict):
    for key, value in stock.items():
        if value <= 0:
            print(f"Removendo Item {key}") 
            stock.popitem()