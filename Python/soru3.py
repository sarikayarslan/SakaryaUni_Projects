import datetime

sayi=int(input("Klavyeden 1-365 araliginda bir sayi giriniz: "))
while True:
    if 365>=sayi and 1<=sayi:
        break
    else:
        sayi=int(input("Lutfen belirtilen kosullarda bir deger giriniz: "))


a = datetime.datetime.today().weekday()
if a == 0:
    bugun = "Pazartesi"
elif a == 1:
    bugun = "Sali"
elif a == 2:
    bugun = "Carsamba"
elif a == 3:
    bugun = "Persembe"
elif a ==4:
    bugun = "Cuma"
elif a == 5:
    bugun = "Cumartesi"
elif a == 6:
    bugun = "Pazar"

bulunacak_gun= sayi%7
gun = (a+ bulunacak_gun)%7
if gun == 0:
    digergun="Pazartesi"
elif gun == 1:
    digergun="Sali"
elif gun == 2:
    digergun="Carsamba"
elif gun == 3:
    digergun="Persembe"
elif gun ==4:
    digergun="Cuma"
elif gun == 5:
    digergun="Cumartesi"
elif gun == 6:
    digergun="Pazar"

print( "Bugün "+str(bugun)+"'dir",sayi," gün sonra haftanın "+str(digergun)+ " günüdür.")