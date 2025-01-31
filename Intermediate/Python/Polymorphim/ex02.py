'''
Implemente um sistema de processamento de pagamentos que suporte diferentes métodos (ex: CartaoCredito, Boleto, PayPal). Cada método de pagamento deve ter um método processar_pagamento(valor) que exibe uma mensagem específica (ex: "Pagamento de R$X via Cartão de Crédito"). Use polimorfismo para processar uma lista de pagamentos de forma uniforme.
'''

class Payment:
    def process_payments(self, value:int = 0):
        pass

class Credit_Card(Payment):
    def process_payments(self, value:int = 0):
        print(f"Payment of R${value} via Credit Card!")

class Ticket(Payment):
    def process_payments(self, value:int = 0):
        print(f"Payment of R${value} via Ticket!")

class PayPal(Payment):
    def process_payments(self, value:int = 0):
        print(f"Payment of R${value} via PayPal!")

credit = Credit_Card()
credit.process_payments(10);

ticket = Ticket()
ticket.process_payments(20);

pay = PayPal()
pay.process_payments(30);