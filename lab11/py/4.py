from typing import Callable

def has_uppercase(password: str) -> bool:
    return any(char.isupper() for char in password)

def has_digit(password: str) -> bool:
    return any(char.isdigit() for char in password)

def is_long_enough(password: str) -> bool:
    return len(password) >= 8

def has_special_char(password: str) -> bool:
    return any(char in "!@#$%^&*()" for char in password)

def no_spaces(password: str) -> bool:
    return " " not in password

def validate_password(password: str) -> bool:
    rules: list[Callable[[str], bool]] = [
        has_uppercase,
        has_digit,
        is_long_enough,
        has_special_char,
        no_spaces
    ]
    return all(rule(password) for rule in rules)

print('Input your password for checking...')
print(validate_password(input()))
