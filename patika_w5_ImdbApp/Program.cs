namespace patika_w5_ImdbApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imdb imdbList = new Imdb();    // yeni bir imdb listesi adında nesne ürettik
            imdbList.AddFilm();   // AddFilm methodunu çağırarak filmleri tanımladık

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--- Bütün Filmler ---");
            Console.ResetColor();

            imdbList.PrintAllFilms();   // Oluşturulan bütün filmleri ekranda göstericek


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--- IMDb Puanı 4 ile 9 Arasında Olan Filmler ---");
            Console.ResetColor();
            imdbList.PrintFilmsWithScoreBetween4And9();  // 4 ile 9 arasında olan filmleri ekranda göstericek

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--- 'A' Harfi ile Başlayan Filmler ---");
            Console.ResetColor();
            imdbList.PrintFilmsStartingWithA(); // A ile başlayan filmleri ekranda göstericek

            Console.ReadKey();
        }
    }
}
