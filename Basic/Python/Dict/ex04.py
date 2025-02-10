'''
Considere um dicionário que armazena informações de um usuário (por exemplo, nome, email, idade, etc.). Proponha operações para:

Atualizar um campo existente (ex.: alterar o email).
Adicionar um novo campo (ex.: número de telefone).
Remover um campo obsoleto (ex.: endereço antigo).
Garanta que, ao executar cada operação, o dicionário mantenha os dados consistentes e atualizados.
'''

def create_dicionary(name:str, email:str, age:int, address:str):
    user = {"name": name, "e-mail": email, "age": age, "address": address}
    return user

def show_itens(user:dict):
    for key, value in user.items():
        print(f"key: {key}, value: {value}")

def update_email(user:dict, new_email:str):
    print(f"Removing previous email: {user['e-mail']}")
    print(f"Updating to the new email: {new_email}")
    user["e-mail"] = new_email
    show_itens(user)

def adding_phone_number(user:dict, phone_n:int):
    print(f"Adding phone number: {phone_n}")
    user["phone"] = phone_n
    show_itens(user)

def remove_old_address(user:dict):
    print(f"Removing old address: {user['address']}")
    del user["address"]
    show_itens(user)

italo = create_dicionary("Italo", "italo@exemple.com", 18, "Rua do Cristo Redentor")
show_itens(italo)
print()
update_email(italo, "thiago@exemple.com")
print()
adding_phone_number(italo, 171171171)
print()
remove_old_address(italo)
