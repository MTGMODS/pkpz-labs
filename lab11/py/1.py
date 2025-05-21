def sort_by_age(people: list[dict]) -> list[dict]:
    return sorted(people, key=lambda person: person["age"])

arr = sort_by_age([
    {"name": "Igor", "age": 22},
    {"name": "Vanya", "age": 17},
    {"name": "Misha", "age": 19}
])

for person in arr:
    print(person)


