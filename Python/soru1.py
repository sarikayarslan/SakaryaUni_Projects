sayi = int(input(" bir sayi giriniz: "))
bolenlist = []
for x in range(1,sayi+1):
    if sayi%x==0:
        bolenlist.append(x)

print("Bu Sayının Tam Bölenleri: ")
print(bolenlist)

if sayi%len(bolenlist)==0:
    
    print("Sayı Bir Tau Sayisidir")
else:
    print("Sayi Bir Tau Sayisi Degildir") 
