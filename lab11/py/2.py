def filter_long_words(words: list[str]) -> list[str]:
    return list(filter(lambda word: len(word) > 3, words))

print(filter_long_words(["a", "the", "code", "Python", "is", "fun"]))
