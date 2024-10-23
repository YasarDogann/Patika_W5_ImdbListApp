using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace patika_w5_ImdbApp
{
    // Film adı ve IMDb puanını tutan sınıf özellikleri
    public class Film
    {
        public string Name { get; set; }
        public double ImdbScore { get; set; }
    }

    public class Imdb
    {
        // Filmleri saklamak için kullanılan bir List yapısı
        private List<Film> films = new List<Film>();

        // Film ekleme fonksiyonu
        public void AddFilm()
        {
            bool isContinue = true;  // Kullanıcı devam etmek istediği sürece döngü devam edecek

            while (isContinue)
            {
                Film film = new Film();   // yeni bir film nesnesi oluşturuldu Polymorphism

                Console.Write("Film Adı Gir: ");  // kullanıcıdan film adı alındı
                film.Name = Console.ReadLine();  // film'in Name Property'sine atandı

                Console.Write("IMDB Puanı Gir: ");   // imdb puanı alındı
                if (double.TryParse(Console.ReadLine(), out double score)) // TryParse ile kontrol yapıldı
                {
                    film.ImdbScore = score;  // Eğer double bir sayı ise film'in ImdbScore propertisine atanacak
                }
                else
                {
                    Console.WriteLine("Geçersiz IMDB puanı! Lütfen sayı girin."); //değilse uyarı vericek ve tekrar soraca
                    continue;
                }

                films.Add(film);  // oluşturulan film nesnesi ad ve imdb puanı alındıktan sonra films listesine eklendi

                Console.Write("Yeni Film Eklemek İstiyor Musunuz? (E / H): ");  // devam edip etmeyeceği soruluyor
                char response = char.Parse(Console.ReadLine().ToUpper());

                if (response != 'E')    // eğer E karakteri harici bişey girerse döngü false olucak ve sonlanacak
                    isContinue = false;
            }
        }

        // Bütün filmleri listeleme fonksiyonu
        public void PrintAllFilms()
        {
            foreach (var film in films)  // Foreach döngüsü ile kaydedilen films listesi içinde geziyoruz ve her birini ekrana yazdırıyoruz.
            {
                Console.WriteLine($"Film Adı: {film.Name}, IMDb Puanı: {film.ImdbScore}");
            }
        }

        // IMDb puanı 4 ile 9 arasında olan filmleri listeleme fonksiyonu
        public void PrintFilmsWithScoreBetween4And9()
        {
            var selectedFilms = films.Where(f => f.ImdbScore >= 4 && f.ImdbScore <= 9).ToList();  // Belirtilen puan arasında olan filmleri listele

            if (selectedFilms.Count == 0)    // Eğer film bulunamazsa mesaj döndürür
            {
                Console.WriteLine("Bu aralıkta film bulunamadı.");
            }
            else
            {
                foreach (var film in selectedFilms)   // uygun olan filmleri ekrana yazdırır
                {
                    Console.WriteLine($"Film Adı: {film.Name}, IMDb Puanı: {film.ImdbScore}");
                }
            }
        }

        // İsmi 'A' harfi ile başlayan filmleri listeleme fonksiyonu
        public void PrintFilmsStartingWithA()
        {
            foreach (var film in films)    // films listesinde teker teker geziyoruz
            {
                if (film.Name.StartsWith("A")|| film.Name.StartsWith("a"))  // A veya a ile başlayan varsa ekrana göstericel
                {
                    Console.WriteLine($"Film Adı: {film.Name}, IMDb Puanı: {film.ImdbScore}");
                }
            }
        }
    }
}
