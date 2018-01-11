# Challenge 002: Side Of The Street
# 
# Answer = "DERECHA" if input is even, IZQUIERDA if it is ODD
# 0 to end

n = int(input())

while n != 0:
    if n % 2 == 0:
        print("DERECHA.")
    else:
        print("IZQUIERDA.")

    n = int(input())

