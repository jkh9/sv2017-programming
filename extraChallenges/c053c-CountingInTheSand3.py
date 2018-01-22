# Challenge 053: Counting in the sand (acepta 369)
# Javier Saorín Vidal
num = int(input())
while num != 0:
    for i in range(num):
        print("1", end="")
    print();
    num = int(input())
