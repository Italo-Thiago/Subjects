def char_remove(old:str, to_remove):
    new_string:str = old.strip().lower()
    for x in to_remove:
        new_string = new_string.replace(x, '')
    return new_string

def is_palindrome(string:str):
    char_remove(string, ".,(#)$ ")
    inverted = string[::-1]
    # inverted = ''.join(reversed(string))
    if inverted == string:
        return True
    else:
        return False

print(f"Oto is palindrome: {is_palindrome("oto")}")
print(f"Italo is palindrome: {is_palindrome("Italo")}")
print(f"Diego is palindrome: {is_palindrome("DIEGO")}")
print(f"ARARA is palindrome: {is_palindrome("ARARA")}")