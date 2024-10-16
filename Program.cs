// See https://aka.ms/new-console-template for more information
class question2
{

    class AsalSayilariTopla
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin:");//kullanıcıdan sayı girilmesi istenilir
            int sayi = int.Parse(Console.ReadLine());// kullanıcıdan alınan sayı okunur
            int toplam = 0;//bulunan asal sayılar toplama eklencektir

            Console.WriteLine("0 ile " +sayi+ " arasındaki asal sayılar:");//girilen sayıya kadar ki tüm asal sayılar yazıılır

            for (int i = 2; i <= sayi; i++)// sırasıyla tüm sayılar denenir
            {
                if (AsalMi(i))//asal olup olmadığını kontrol eden metod
                {
                    Console.Write(i + " ");// asal olduğu bulunann sayılar yazılır
                    toplam += i; // Asal sayıyı toplama ekle
                }
            }

            Console.WriteLine("\nAsal sayıların toplamı: "+ toplam);//bulunan asal sayıların toplamı burdan ekrana yazılır
        }

        static bool AsalMi(int n)//asal olup olmadığını kontrol eder asalsa değeri döndürür
        {
            if (n < 2) return false; // 2'den küçük sayılar asal değildir
            for (int i = 2; i <= Math.Sqrt(n); i++)// asallık kontrolü yaparken değerin karekökü alınıp sadece o değere kadar olans sayılara bölünmesi işlem yükünü azaltır
            {
                if (n % i == 0) return false; // Bölünebiliyorsa asal değildir
            }
            return true; // Asaldır
        }
    }
}