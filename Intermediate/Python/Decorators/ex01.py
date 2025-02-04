'''
Exercício 1: Controle de Acesso em Funções
Objetivo: Criar um decorator que verifica se um usuário tem permissão para executar uma função.
Contexto: Em um sistema de autenticação, algumas funções só podem ser executadas por usuários com roles específicos (ex: "admin").
Requisitos:

- O decorator deve receber uma lista de roles permitidos.
- Se o usuário atual (representado por um dicionário com {"name": str, "role": str}) não tiver a role necessária, levante uma exceção PermissionError.
- A função decorada deve receber o usuário como primeiro argumento.
'''
def check_user_permission(expected_user:dict):
    def decorator(function):
        def wrapper(user, *args, **kwargs):
            if user != expected_user["role"]:
                raise PermissionError("Permission Error")
            return function(*args, **kwargs)
        return wrapper
    return decorator

@check_user_permission(expected_user = {"name": "Italo", "role": "admin"})
def delete_database():
    print("Database deleted");

try:
    delete_database("admin")
except PermissionError as e:
    print(e)
