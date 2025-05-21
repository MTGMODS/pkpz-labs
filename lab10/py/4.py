from typing import Iterator

def walk_tree(data: dict) -> Iterator[str]:
    for key, value in data.items():
        yield key
        if isinstance(value, dict):
            yield from walk_tree(value)

if __name__ == "__main__":
    tree = {
        "a": {
            "b": 2222,
            "c": 98818,
            "d": {
                "f": 111
            }
        },
        "e": 923923
    }
    print("Ключі дерева:", list(walk_tree(tree)))
