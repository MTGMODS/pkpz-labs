from typing import Iterator

def walk_tree(data: dict) -> Iterator[str]:
    for key, value in data.items():
        yield key
        if isinstance(value, dict):
            yield from walk_tree(value)

if __name__ == "__main__":
    tree = {
        "a": {"b": {"c": 1}},
        "d": 2
    }
    print("Ключі дерева:", list(walk_tree(tree)))
