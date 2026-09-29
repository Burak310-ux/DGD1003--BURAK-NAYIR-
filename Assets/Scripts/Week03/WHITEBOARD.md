# Whiteboard - Week 3 Vocabulary

- method: bir isim verilmis, tek bir yerde yazilan ve istenen her yerden
  cagrilabilen kod parcasi (ornek: AddBeast, ListBeasts).
- parameter: metodun basliginda yazan, metodun kendi icinde kullandigi
  degisken adi (ornek: AddBeast(string name) icindeki name).
- argument: metodu cagirirken gercekten verilen deger
  (ornek: AddBeast(nameToAdd) icindeki nameToAdd).
- return value: metodun is bitince geri verdigi deger
  (ornek: ReadChoice 1-5 veya 0 dondurur).
- void: metodun hicbir deger geri vermedigini gosterir
  (ornek: void PrintMenu()).
- scope: bir degiskenin gorulebildigi alan; hangi suslu parantezlerin
  icinde tanimlandiysa orada yasar.
- refactoring: programin ne yaptigini degistirmeden kodun seklini
  duzeltmek (ornek: iki kopya hasar formulunu tek metoda toplamak).
- array: sabit boyutlu, ayni tipte degerleri numarali slotlarda tutan
  yapi (ornek: string[] menuItems).
- index: bir dizideki veya listedeki elemanin numarasi, 0'dan baslar.
- Length: bir dizinin kac elemani oldugunu verir; son indeks Length - 1.
- off-by-one: sinirda bir fazla veya bir eksik sayma hatasi
  (ornek: i <= Length yazmak, ya da slot - 1 yapmayi unutmak).
- List<T>: boyutu oyun sirasinda buyuyup kuculebilen koleksiyon
  (ornek: List<string> storage, Add ve RemoveAt ile).
- Count: bir listede kac eleman oldugunu verir.
- foreach: bir koleksiyondaki her elemani sirayla gezen dongu; indeks
  vermez, icinde eleman eklenip cikarilamaz.
- switch: tek bir degiskeni kesin degerlerle karsilastirip sadece
  eslesen case'i calistiran yapi; her case break ile biter.
