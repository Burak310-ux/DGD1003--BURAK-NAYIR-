# Exercise 2 - README

## 1. Derleyici ne yapar?
Derleyici, yazdigim C# kodunu bilgisayarin anlayabilecegi dile cevirir.
Kodda bir hata varsa (yazim hatasi, eksik parantez gibi) cevirmeyi durdurur
ve programi calistirmaz; hangi dosyada, hangi satirda ne hata oldugunu
Console'da gosterir.

## 2. hp degiskeni Start icinde tanimli, Update onu yazdirmaya calisiyor
Console "The name 'hp' does not exist in the current context" gibi bir hata
verir, cunku hp sadece Start metodu icinde yasayan bir local degiskendir,
Update onu goremez.
Iki cozum yolu:
1) hp'yi field yapmak (class'in en ustunde, metotlarin disinda tanimlamak),
   boylece tum metotlar erisebilir.
2) hp'yi Update icinde de ayrica tanimlamak (ama bu, Start'taki degeri
   Update'e tasimaz, farkli bir degisken olur).

## 3. int hp = 13, maxHp = 20;
- hp / maxHp = 0  (int bolme, 13/20 ondalikli sonuc olan 0.65'i verir ama
  int'ler ondalik tutamadigi icin virgulden sonrasi atilir, sonuc 0 olur)
- hp * 100 / maxHp = 65  (once carpma yapilir: 13*100=1300, sonra 1300/20=65)
- (float)hp / maxHp = 0.65  (hp once float'a cevrildigi icin bolme
  ondalikli yapilir, gercek sonuc korunur)

## 4. Kosullar
- Savas devam ediyor: playerHp > 0 && rivalHp > 0 && turn <= 30
- Savas bitti: playerHp <= 0 || rivalHp <= 0 || turn > 30

## 5. Random.Range(1, 6)
5 farkli deger uretebilir: 1, 2, 3, 4, 5
(Random.Range int parametrelerle calisirken ust sinir haric tutulur,
yani 6 asla gelmez.)

## 6. Start icinde sonsuz while dongusu
Unity editoru donar (freeze), tepki vermez, Console'a yeni bir sey
yazilmaz cunku dongu hic bitmiyordur. Kurtulmanin tek yolu Unity'yi
zorla kapatmaktir (Task Manager'dan), ve o ana kadar kaydedilmemis
tum degisiklikler kaybolur.
Bunu onleyen iki alışkanlık:
1) Play'e basmadan once her zaman Ctrl+S ile kaydetmek.
2) while dongusune turn <= 30 gibi bir ust sinir (guvenlik kemeri)
   koymak, boylece dongu belirli bir sayida turdan sonra kesin biter.

## Extension
Iki ozellik ekledim: (1) her saldiridan sonra kalan HP'yi [######----] 
seklinde bir cubukla gosteren MakeHpBar adinda bir fonksiyon, for dongusu 
kullanarak Start'in ustunde ayri bir metot olarak yazildi. (2) her 
saldirida %6.25 ihtimalle (Random.Range(0,16)==0) hasarin iki katina 
cikip "A critical hit!" yazdiran bir kontrol, hem oyuncu hem rakip 
saldirilarinda, damage hesaplandiktan hemen sonra.
