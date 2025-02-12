'''
Validação de CPF: Crie um programa que valide se um número de CPF é válido, verificando se os dígitos verificadores estão corretos.
'''

# CPF deve vir no formato 123.456.789-10
def validate(cpf:str):
    if len(cpf) < 15 and cpf[3] == '.' and cpf[7] == '.' and cpf[11] == '-':
        print(f"CPF: {cpf}")
        print(f"Valid")
    else:
        print(f"CPF: {cpf}")
        print(f"Invalid")
        
validate("123.456.789-10")
print()
validate("12345678910")