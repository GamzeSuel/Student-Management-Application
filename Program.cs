namespace OkulYonetimUygulamasi_TP115_Temel
{
    internal class Program
    {
        static Okul Okul = new Okul();
        static void Main(string[] args)
        {
            //kullanıcı ile etkileşime girdiğimiz kodlar buraya yazılabilir. Ya da Uygulama sınıfı açabilirsiniz.

        }

        static void Uygulama()
         
        {
            SahteVeriGir();

            //Menu
            //SecimAl
            //Switch-Case
        }

        static void NotGir()
        {
            try
            {
                Console.WriteLine("-20-Not Gir ------------------------------------");
                Console.Write("Öğrencinin Numarası: ");
                int no = int.Parse(Console.ReadLine());

                //bu numaralı öğrencinin bilgileri bulunup ekrana yazılacak.

                string dersAdi = Console.ReadLine();     //Hangi ders?

                int adet = int.Parse(Console.ReadLine());    //kaç adet not?

                for (int i = 1; i < adet; i++)
                {
                    Console.Write(i + ".notu girin: ");
                    int not = int.Parse(Console.ReadLine());
                    Okul.NotEkle(no, dersAdi, not);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
        static void SahteVeriGir()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            Okul.OgrenciEkle(1, "Naz", "Kaya", SUBE.A, new List<int> { 85, 90 }, new List<string> { "Kitap 1", "Kitap 2" }, CINSIYET.Kiz, new DateTime(2005, 5, 1), "İstanbul");
            Okul.OgrenciEkle(2, "Elif", "Yılmaz", SUBE.A, new List<int> { 75, 80 }, new List<string> { "Kitap 3", "Kitap 4" }, CINSIYET.Kiz, new DateTime(2004, 6, 12), "Ankara");
            Okul.OgrenciEkle(3, "Busra", "Demir", SUBE.B, new List<int> { 60, 70 }, new List<string> { "Kitap 5", "Kitap 6" }, CINSIYET.Kiz, new DateTime(2003, 7, 23), "İzmir");
            Okul.OgrenciEkle(4, "Hakan", "Çelik", SUBE.B, new List<int> { 65, 75 }, new List<string> { "Kitap 7", "Kitap 8" }, CINSIYET.Erkek, new DateTime(2004, 8, 14), "Bursa");
            Okul.OgrenciEkle(5, "Ahmet", "Koç", SUBE.B, new List<int> { 90, 95 }, new List<string> { "Kitap 9", "Kitap 10" }, CINSIYET.Erkek, new DateTime(2005, 9, 5), "Adana");
            Okul.OgrenciEkle(6, "Mehmet", "Aslan", SUBE.C, new List<int> { 70, 80 }, new List<string> { "Kitap 11", "Kitap 12" }, CINSIYET.Erkek, new DateTime(2003, 10, 16), "Antalya");
            Okul.OgrenciEkle(7, "Beril", "Yıldız", SUBE.C, new List<int> { 80, 85 }, new List<string> { "Kitap 13", "Kitap 14" }, CINSIYET.Kiz, new DateTime(2004, 11, 27), "Konya");
           
            List<Ogrenci> YENİLİSTE = ogrenciler.Where(item => item.Sube = SUBE.B.).ToList();

        
        
        
        }





        //Başka öğrenciler de ekleyebililirsiniz.

        //Adres , DersNotu , Kitap gibi veriler için de sahte veri oluşturulmalı… 
    }

}
























       






