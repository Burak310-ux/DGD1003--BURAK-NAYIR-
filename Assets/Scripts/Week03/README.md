# Exercise 3 - README

## 1. Parametre ile argüman farkı
Parametre, metodun başlığındaki isimdir; metodun kendi kullandığı 
değişken adıdır. Argüman ise çağrı sırasında gerçekten verilen 
değerdir.
Örnek: void AddBeast(string name) satırında name parametredir.
AddBeast(nameToAdd); çağrısında nameToAdd argümandır.

## 2. void ne demek?
void, bir metodun hiçbir değer döndürmediği anlamına gelir. 
int x = PrintStatus(); yazarsam Console CS0029 hatası verir: 
"Cannot implicitly convert type 'void' to 'int'", çünkü void 
metottan saklanacak bir değer yoktur.

## 3. string[] moves dizisi
moves.Length = 4
moves[3] = "BITE"
moves[4] yazarsam IndexOutOfRangeException hatası alırım, çünkü 
4 elemanlı dizide gecerli indeksler 0'dan 3'e kadardır.

## 4. Array veya List<T>
Array: parti (party) 6 sabit slot gibi, oyunun kuralı sayıyı 
belirliyorsa array kullanılır, çünkü boyut hiç değişmez.
List<T>: PC deposu gibi, oyun sırasında eleman sayısı değişiyorsa 
List kullanılır, çünkü Add ve RemoveAt ile büyüyüp küçülebilir.

## 5. RemoveAt(slot - 1) neden?
Oyuncuya slotlar 1'den başlayarak gösteriliyor ama C# dizilerinde 
ve listelerinde
