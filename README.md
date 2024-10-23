# Patika+ Week5 Lists1 Uygulaması
Merhaba,
Bu proje C# ile Patika+ 5.hafta Lists için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- List yapısını öğrenmek
- Döngüler'i kullanmak
- Class Yapısını kullanmak
- Encapsulation yapısını kullanmak
- Polymorphism yapısını kullanmak


## İstenilen Görev
![BXy5S-K-movie-9pvmdtvz4cb0xl37](https://github.com/user-attachments/assets/2d2f8170-1bc3-42a3-a725-87c57fbf6885)
![YxJF9NG-imdblist](https://github.com/user-attachments/assets/28dbbe0e-603c-4721-970a-734626ae79ed)

Aşağıda belirtilen adımları gerçekleştirerek bir Imdb - Film Listesi oluşturuyoruz.
    Sinema Filmlerini listeleyeceğimiz bir liste oluşturalım
    Film için propertyler -> Imdb Puanı (Double) - İsmi 
    Kullanıcıdan sınırsız sayıda film adı ve imdb puanı isteyip bu bilgilerle nesneler oluşturulup liste doldurulacak.
     Kullanıcıya her film eklemesinden sonra yeni bir film eklemek isteyip istemediği sorulsun. Kullanıcı evet cevabını verirse döngüde başa dönülerek yeni bir film oluşturulup ilgili listeye aktarılsın. Hayır cevabı verilirse program aşağıdaki çıktıları ayrı ayrı sunarak sonlandırılsın.
    Uygulamanın sonunda
    1-  Bütün filmler listelensin.
    2-  Imdb puanı 4 ile 9 arasında olan bütün filmler listelensin.
    3-  İsmi 'A' ile başlayan filmler ve imdb puanları listelensin.



Örnek veri giriş ekranı :
![-y_hGXH-davetliler](https://github.com/user-attachments/assets/5e18f653-26a5-4889-a99e-e53607d5da9d)

Örnek Program Çıktısı:
![CO-cHvZ-kkkk](https://github.com/user-attachments/assets/42e171c9-321c-4d15-b745-2c031c84789c)


## Kod 
```csharp
 static void Main(string[] args)
 {
     List<string> coffees = new List<string>();

     Console.WriteLine("Lütfen 5 adet Kahve giriniz");

     for(int i = 0; i< 5; i++)
     {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.Write($"Kahve {i+1} : ");
         Console.ResetColor();

         Console.ForegroundColor = ConsoleColor.Green;
         coffees.Add(Console.ReadLine());
         Console.ResetColor();
     }

     Console.WriteLine("\r\nGirilen Kahve İsimleri: ");
     foreach(string coffee in coffees)
     {
         Console.WriteLine(coffee);
     }

     Console.Read();
 }
```





