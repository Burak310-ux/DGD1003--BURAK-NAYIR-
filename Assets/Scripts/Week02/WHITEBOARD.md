# Whiteboard - Vocabulary

## Week 1
- source code / running program: source code benim yazdigim, insan
  tarafindan okunabilir C# metnidir. Derleyici bunu makine diline
  cevirince ortaya calisan program (calistirilabilir hal) cikar.
- string: metin (yazi) tutan veri tipi, ornek: trainerName
- verbatim string (@"..."): icindeki ozel karakterleri (ornegin \n)
  oldugu gibi yazdiran, birden fazla satira yayilabilen string turu
- interpolation ($"..."): string icine degisken degerlerini dogrudan
  {degisken} seklinde yazmayi saglayan yontem
- interpolated verbatim string ($@"..."): hem cok satirli olabilir
  hem de icinde {degisken} kullanabilirim, ikisini birlestirir
- field (public int level gibi): class'in en ustunde tanimlanan,
  Inspector'da gorunen ve degistirilebilen degisken
- int: tam sayi tutan veri tipi (ondalik kismi olmaz)
- float: ondalikli sayi tutan veri tipi
- int bolme: iki tam sayi bolununce sonuc da tam sayi olur, ondalik
  kisim atilir; 7/2 = 3 ama 7.0/2 = 3.5 olur cunku biri float
- bool: sadece true veya false degerini tutan veri tipi
- DivideByZeroException: bir sayi 0'a bolunmeye calisildiginda
  Unity'nin verdigi hata, programi o noktada durdurur
- Start() ve Update(): Start() oyun basladiginda sadece bir kere
  calisir, Update() ise her frame'de (saniyede onlarca kez) tekrar
  tekrar calisir

## Week 2
- field: class'in en ustunde tanimlanan, tum metotlarin erisebildigi
  degisken (ornek: playerName, playerMaxHp)
- local (degisken): bir metodun (ornegin Start) icinde tanimlanan ve
  sadece o metot bitene kadar yasayan degisken (ornek: playerHp, turn)
- while dongusu: bir kosul dogru oldugu surece icindeki kodu tekrar
  tekrar calistiran dongu
- if / else: bir kosula gore farkli kod bloklarini calistirmayi saglar
- && (ve): iki kosulun da dogru olmasi gerekir
- || (veya): kosullardan en az birinin dogru olmasi yeterlidir
- Random.Range(min, max): min ile max arasinda (int icin max haric)
  rastgele bir sayi uretir
- for dongusu: belirli bir sayida tekrar yapmak icin kullanilan dongu,
  HP bar cizerken kullandim
