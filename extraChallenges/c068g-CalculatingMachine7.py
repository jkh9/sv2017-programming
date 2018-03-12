# -*- coding: utf-8 -*-

# Ejemplo de entrada
# 5
# 5 + -13
# 10 / 2
# 7 * 3
# 3 / 0
# 5 - 13

# Ejemplo de salida
# -8
# 5
# 21
# ERROR
# -8

n = int(input())
for i in range (0,n):
    operation = raw_input().split()
    n1 = int(operation[0])
    op = operation[1]
    n2 = int(operation[2])
    if op == '+':
        print(n1+n2)
    elif op == '-':
        print(n1-n2)
    elif op == '*':
        print(n1*n2)
    elif op == '/':
        if n2 == 0:
            print("ERROR")
        else:
            print(n1/n2)
