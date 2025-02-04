# PT: Crie um programa que solicite ao usuário o valor total de sua compra. Aplique um desconto de 10% no total da compra. Imprima o valor após o desconto.
# EN: Create a program that asks the user for the total value of their purchase. Apply a 10% discount to the total purchase. Print the value after the discount.

try:
    # PT: Solicita o valor total da compra ao usuário
    # EN: Ask the user for the total purchase amount
    total_value = float(input("Enter the total purchase amount $: "));
    assert total_value > 0;
    
    # PT: Calcula e imprime o valor com desconto
    # EN: Calculate and print the value after discount
    print(f"The amount $ {total_value :,.2f} with a 10% discount is equal to $ {total_value - (total_value * 0.1) :,.2f}");
    
except (ValueError, AssertionError):
    # PT: Mensagem de erro para valores inválidos
    # EN: Error message for invalid values
    print("Please enter a positive value!");