# EN: Ask the user to enter a number of days and convert it in seconds
# PT: Peça ao usuário para inserir um número de dias e converte-o em segundos

days = int(input("Enter a number of days: "))
# EN: 86400 and equal to 24(days) * 60(minutes) * 60(seconds)
# PT: 86400 e igual a 24(dias) * 60(minutos) * 60(segundos)
print("Days converted to seconds equal to: {:,.2f} seconds".format(days * 86400))
