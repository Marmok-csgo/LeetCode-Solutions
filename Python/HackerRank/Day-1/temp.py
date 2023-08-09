import math
def squares(a, b):
    res = 0
    for i in range(a, b + 1):
        Str = str(math.sqrt(i)).split('.')
        if int(Str[1]) == 0:
            res += 1
    return res


if __name__ == "__main__":
    print(squares(3, 9))

