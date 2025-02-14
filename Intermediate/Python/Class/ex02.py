'''
Sistema de Gerenciamento de Loja Virtual

1. Modelar classes para representar Produto, Cliente, Pedido e Pagamento.
2. Utilizar herança e polimorfismo para diferenciar categorias de produtos ou métodos de pagamento (ex.: Cartão, Boleto, Pix).
3. Aplicar composição para associar pedidos aos clientes e aos produtos.
4. Implementar métodos de validação para controle de estoque, processamento de pagamento e geração de relatórios de vendas.
'''
# Lembre-se de usar return

import random

class Produto:
    def __init__(self, id ,nome, preco):
        self.id = id
        self.nome = nome
        self.preco = preco

class Cliente:
    def __init__(self, nome, dinheiro):
        self.nome = nome
        self.dinheiro = dinheiro

class Pedido:
    def __init__(self, id, cliente:Cliente, lista_produtos:list = []):
        self.id = id
        self.cliente = cliente
        # Lista de ids de produto
        self.lista_produtos = lista_produtos

    def adicionar_pedido(self, novo_produto:Produto):
        print(f"Adicionando produto: {novo_produto.nome}, na lista do cliente: {self.cliente.nome}")
        self.lista_produtos.append(novo_produto)

    def remover_pedido(self, produto:Produto):
        print(f"Removendo pedido: {produto.nome}")
        self.lista_produtos.remove(produto)

    def mudar_pedido(self, antigo:Produto, novo:Produto):
        print(f"Mudando pedido antigo \"{antigo.nome}\", por \"{novo.nome}\"")
        for i, produto in enumerate(self.lista_produtos):
            if produto == antigo:
                self.lista_produtos[i] = novo
       
    def mostrar_pedidos(self):
        print(f"Mostrando pedidos do Cliente: {self.cliente.nome}")
        for produto in self.lista_produtos:
            print(f"Produto {produto.id}: {produto.nome}")

class Pagamento:
    def __init__(self, parcelas):
        self.parcelas = parcelas
        pass

    def realizar_pagamento(self, pedido):
        pass

class Cartao(Pagamento):
    def __init__(self, modo, parcelas):
        super().__init__(parcelas)
        self.modo = modo

    def realizar_pagamento(self, pedido:Pedido):
        print(f"Realizando pagamento na modalidade Cartão de {self.modo}.")
        valor_final = 0
        for produtos in pedido.lista_produtos:
            valor_final += produtos.preco
        if valor_final > pedido.cliente.dinheiro:
            print("Não foi possível realizar o pagamento")
        else:
            print("O Pagamento foi aceito")
            parcelamento = valor_final / self.parcelas
            print(f"O valor das parcelas ficou em: R${parcelamento:,.2f}")
          

class Pix(Pagamento):
    def __init__(self, parcelas):
        super().__init__(parcelas)
        self.codigo = 0

    def gerar_codigo(self, pedido:Pedido):
        codigo = random.randint(000000000, 999999999)
        self.codigo = codigo
        print(f"O código do pedido: {pedido.id}, é igual a: {codigo}.")
        return codigo

    def realizar_pagamento(self, pedido:Pedido, codigo):
        print(f"Realizando pagamento na modalidade Pix.")
        valor_final = 0
        if codigo != self.codigo:
            print("Código invalido")
        else:
            for produtos in pedido.lista_produtos:
                valor_final += produtos.preco
            if valor_final > pedido.cliente.dinheiro:
                print("Não foi possível realizar o pagamento")
            else:
                print("O Pagamento foi aceito")
                parcelamento = valor_final / self.parcelas
                print(f"O valor das parcelas ficou em: R${parcelamento:,.2f}")
    
class Boleto(Pagamento):
    def __init__(self, parcelas, data:int):
        super().__init__(parcelas)
        self.data = data

    def mudar_data(self, nova_data:int):
        print(f"Modificando data antiga: {self.data}, para nova data {nova_data}")
        self.data = nova_data

    def realizar_pagamento(self, pedido:Pedido, data_atual):
        print(f"Realizando pagamento na modalidade Boleto.")
        valor_final = 0
        if data_atual > self.data:
            print("Pagamento realizado fora da Data")
        else:
            for produtos in pedido.lista_produtos:
                valor_final += produtos.preco
            if valor_final > pedido.cliente.dinheiro:
                print("Não foi possível realizar o pagamento")
            else:
                print("O Pagamento foi aceito")
                parcelamento = valor_final / self.parcelas
                print(f"O valor das parcelas ficou em: R${parcelamento:,.2f}")

carrinho = Produto(1, "Carrinho controle remoto", 10)
boneca = Produto(2, "Boneca Chapeuzinho vermelho", 20)
tales = Cliente("Tales", 200)

pedido_tales = Pedido(1, tales, [carrinho, boneca])
pedido_tales.mostrar_pedidos()

print()
casa = Produto(10, "Casa da Vovó", 100)
pedido_tales.adicionar_pedido(casa)
pedido_tales.mostrar_pedidos()

print()
travesseiro = Produto(4, "Travesseiro de penas de canso africano", 180)
pedido_tales.mudar_pedido(carrinho, travesseiro)
pedido_tales.mostrar_pedidos()

print()
pedido_tales.remover_pedido(casa)
pedido_tales.mostrar_pedidos()

print()
credito = Cartao("Credito", 10)
credito.realizar_pagamento(pedido_tales)

print()
pix = Pix(10)
chave_pix = pix.gerar_codigo(pedido_tales)
codigo = 123456789
pix.realizar_pagamento(pedido_tales, chave_pix)

print()
boleto = Boleto(10, 13022025)
boleto.mudar_data(14022025)
boleto.realizar_pagamento(pedido_tales, 10022025)
print()
boleto.realizar_pagamento(pedido_tales, 15022025)