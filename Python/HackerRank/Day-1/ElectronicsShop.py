def getMoneySpent(keyboards, drives, b):
    Res = []
    for i in keyboards:
        for j in drives:
            if i+j <= b:
                Res.append(i+j)

    return max(Res) if len(Res) > 0 else -1

if __name__ == "__main__":
    b1 = 60
    keyboards1 = [40, 50, 60]
    drives1 = [5, 8, 12]
    print(getMoneySpent(keyboards1, drives1, b1))

