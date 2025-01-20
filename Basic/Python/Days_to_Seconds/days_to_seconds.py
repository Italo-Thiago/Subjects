# EN: Ask the user to enter a number of days and convert it to seconds
# PT: Peça ao usuário para inserir um número de dias e convertê-lo em segundos

# EN: 86400 is equal to 24(hours) * 60(minutes) * 60(seconds)
# PT: 86400 é igual a 24(horas) * 60(minutos) * 60(segundos)

try:
    # EN: Ask the user to enter the number of days
    # PT: Peça ao usuário para inserir o número de dias
    days = int(input("Enter the number of days: "))
    assert days > 0
    
    # EN: Print the number of days converted to seconds
    # PT: Imprima o número de dias convertido em segundos
    print(f"{days} days converted to seconds is equal to: {days * 86400:,.2f} seconds")
    
except (ValueError, AssertionError):
    # EN: Print an error message if the input is not a positive number
    # PT: Imprima uma mensagem de erro se a entrada não for um número positivo
    print("Please enter a positive number!")