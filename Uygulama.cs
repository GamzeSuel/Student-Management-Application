using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_TP115_Temel
{
    internal class Uygulama
    {
       

        private int sayac = 0;
        private List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public void Calistir()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

        
            Menu();
            while (true)
            {
                string secim = SecimAl();
                Console.WriteLine();
                switch (secim)
                {


                    case "1":
                        BütünÖğrencileriListele(ogrenciler);
                        break;

                    case "2":
                        ŞubeyeGöreÖğrencileriListele(ogrenciler);
                        break;

                    case "3":
                        CinsiyetineGöreÖğrencileriListele(ogrenciler);
                        break;

                    case "4":
                        ŞuTarihtenSonraDoğanÖğrencileriListele(ogrenciler);
                        break;

                    case "5":
                        İllereGöreSıralayarakÖğrencileriListele(ogrenciler);
                        break;

                    case "6":
                        ÖğrencininTümNotlarınıListele(ogrenciler);
                        break;

                    case "7":
                        ÖğrencininOkuduğuKitaplarıListele(ogrenciler);
                        break;


                    case "8":
                        OkuldakiEnYüksekNotlu5ÖğrenciyiListele(ogrenciler);
                        break;

                    case "9":
                        OkuldakiEnDüşükNotlu3ÖğrenciyiListele(ogrenciler);
                        break;

                    case "10":
                        ŞubedekiEnYüksekNotlu5ÖğrenciyiListele(ogrenciler);
                        break;

                    case "11":
                        ŞubedekiEnDüşükNotlu3ÖğrenciyiListele(ogrenciler);
                        break;

                    case "12":
                        ÖğrencininNotOrtalamasınıGör(ogrenciler);
                        break;

                    case "13":
                        ŞubeninNotOrtalamasınıGör(ogrenciler);
                        break;


                    case "14":
                        ÖğrencininOkuduğuSonKitabıGör(ogrenciler);
                        break;

                    case "15":
                        ÖğrenciEkle(ogrenciler);
                        break;


                    case "16":
                        ÖğrenciGüncelle(ogrenciler);
                        break;


                    case "17":
                        ÖğrenciSil(ogrenciler);
                        break;


                    case "18":
                        ÖğrencininAdresiniGir(ogrenciler);
                        break;

                    case "19":
                        ÖğrencininOkuduğuKitabıGir(ogrenciler);
                        break;

                    case "20":
                        ÖğrencininNotunuGir(ogrenciler);
                        break;

                    case "ÇIKIŞ":
                        Cikis();
                        break;

                    default:
                        Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                        sayac++;
                        break;






                }

            }



        }

        public void Menu()
        {
            Console.WriteLine("Okul Yönetimi                                         ");
            Console.WriteLine("1- Bütün Öğrencileri Listele                          ");
            Console.WriteLine("2- Şubeye Göre Öğrencileri Listele                    ");
            Console.WriteLine("3- Cinsiyetine göre öğrencileri listele               ");
            Console.WriteLine("4- Şu tarihten sonra doğan öğrencileri listele        ");
            Console.WriteLine("5- İllere göre sıralayarak öğrencileri listele        ");
            Console.WriteLine("6- Öğrencinin tüm notlarını listele                   ");
            Console.WriteLine("7- Öğrencinin okuduğu kitapları listele               ");
            Console.WriteLine("8- Okuldaki en yüksek notlu 5 öğrenciyi listele       ");
            Console.WriteLine("9- Okuldaki en düşük notlu 3 öğrenciyi listele        ");
            Console.WriteLine("10-Şubedeki en yüksek notlu 5 öğrenciyi listele       ");
            Console.WriteLine("11-Şubedeki en düşük notlu 3 öğrenciyi listele        ");
            Console.WriteLine("12-Öğrencinin not ortalamasını gör                    ");
            Console.WriteLine("13-Şubenin not ortalamasını gör                       ");
            Console.WriteLine("14-Öğrencinin okuduğu son kitabı gör                  ");
            Console.WriteLine("15-Öğrenci ekle                                       ");
            Console.WriteLine("16-Öğrenci güncelle                                   ");
            Console.WriteLine("17-Öğrenci sil                                        ");
            Console.WriteLine("18-Öğrencinin adresini gir                            ");
            Console.WriteLine("19-Öğrencinin okuduğu kitabı gir                      ");
            Console.WriteLine("20-Öğrencinin notunu gir                              ");

        }

        public string SecimAl()
        {
            if (sayac != 10)
            {
                Console.WriteLine();
                Console.Write("Seçiminiz: ");
                return Console.ReadLine().ToUpper();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                return "ÇIKIŞ";
            }

        }

        public void Cikis()
        {
            Environment.Exit(0);
        }

        public void BütünÖğrencileriListele(List<Ogrenci> liste)
        {
            Console.WriteLine("Sube".PadRight(5) + "No".PadRight(5) + "Adı Soyadı".PadRight(10) + "Okuduğu Kitap Say.".PadRight(5));

            Console.WriteLine("".PadRight(52, '-'));

            foreach (Ogrenci item in liste)
            {
                Console.WriteLine(item.Sube.ToString().PadRight(5) + item.No.ToString().PadRight(5) + item.Ad.PadRight(10) + item.Soyad.PadRight(10)
                     + item.Kitaplar.ToString().PadRight(5));
            }
        }


        public void ŞubeyeGöreÖğrencileriListele(List<Ogrenci> liste)
        {
            Console.WriteLine("Şube seçiniz (A/B/C): ");
            string subeSecim = Console.ReadLine().ToUpper();
            SUBE sube;
            if (!Enum.TryParse(subeSecim, out sube))
            {
                Console.WriteLine("Geçersiz şube seçimi.");
                return;
            }

            var subeOgrencileri = liste.Where(a => a.Sube == sube).ToList();
            BütünÖğrencileriListele(subeOgrencileri);
        }

        public void CinsiyetineGöreÖğrencileriListele(List<Ogrenci> liste)
        {
            Console.WriteLine("Cinsiyet seçiniz (Kiz/Erkek): ");
            string cinsiyetSecim = Console.ReadLine();
            CINSIYET cinsiyet;
            if (!Enum.TryParse(cinsiyetSecim, out cinsiyet))
            {
                Console.WriteLine("Geçersiz cinsiyet seçimi.");
                return;
            }

            var cinsiyetOgrencileri = liste.Where(a => a.Cinsiyet == cinsiyet).ToList();
            BütünÖğrencileriListele(cinsiyetOgrencileri);
        }

        public void ŞuTarihtenSonraDoğanÖğrencileriListele(List<Ogrenci> liste)
        {
            Console.WriteLine("Tarih giriniz (yyyy-mm-dd): ");
            DateTime tarih;
            if (!DateTime.TryParse(Console.ReadLine(), out tarih))
            {
                Console.WriteLine("Geçersiz tarih formatı.");
                return;
            }

            var tarihOgrencileri = liste.Where(a => a.DogumTarihi > tarih).ToList();
            BütünÖğrencileriListele(tarihOgrencileri);
        }

        public void İllereGöreSıralayarakÖğrencileriListele(List<Ogrenci> liste)
        {
            var illereGoreOgrenciler = liste.OrderBy(a => a.Adresi).ToList();
            BütünÖğrencileriListele(illereGoreOgrenciler);
        }

        public void ÖğrencininTümNotlarınıListele(List<Ogrenci> liste)
        {
            Console.WriteLine("Öğrenci No giriniz: ");
            int no;
            if (!int.TryParse(Console.ReadLine(), out no))
            {
                Console.WriteLine("Geçersiz öğrenci numarası.");
                return;
            }

            var ogrenci = liste.FirstOrDefault(a => a.No == no);
            if (ogrenci == null)
            {
                Console.WriteLine("Öğrenci bulunamadı.");
                return;
            }

            Console.WriteLine($"Öğrenci: {ogrenci.Ad} {ogrenci.Soyad}");
            Console.WriteLine("Notlar: " + string.Join(", ", ogrenci.Notlar));
        }

        public void ÖğrencininOkuduğuKitaplarıListele(List<Ogrenci> liste)
        {
            {
                Console.WriteLine("Öğrenci No giriniz: ");
                int no;
                if (!int.TryParse(Console.ReadLine(), out no))
                {
                    Console.WriteLine("Geçersiz öğrenci numarası.");
                    return;
                }

                var ogrenci = liste.FirstOrDefault(a => a.No == no);
                if (ogrenci == null)
                {
                    Console.WriteLine("Öğrenci bulunamadı.");
                    return;
                }

                Console.WriteLine($"Öğrenci: {ogrenci.Ad} {ogrenci.Soyad}");
                Console.WriteLine("Kitaplar: " + string.Join(", ", ogrenci.Kitaplar));
            }
        }
        public void OkuldakiEnYüksekNotlu5ÖğrenciyiListele(List<Ogrenci> liste)

        {
                var enYuksekNotlu5 = liste.OrderByDescending(a => a.Notlar.Average()).Take(5).ToList();
                BütünÖğrencileriListele(enYuksekNotlu5);
        }

        static void OkuldakiEnDüşükNotlu3ÖğrenciyiListele(List<Ogrenci> liste)
        {
                var enDusukNotlu3 = liste.OrderBy(a => a.Notlar.Average()).Take(3).ToList();
                BütünÖğrencileriListele(enDusukNotlu3);
        }

        public void ŞubedekiEnYüksekNotlu5ÖğrenciyiListele(List<Ogrenci> liste)
        {
                Console.WriteLine("Şube seçiniz (A/B/C): ");
                string subeSecim = Console.ReadLine().ToUpper();
                SUBE sube;
                if (!Enum.TryParse(subeSecim, out sube))
                {
                    Console.WriteLine("Geçersiz şube seçimi.");
                    return;
                }

                var subeOgrencileri = liste.Where(a => a.Sube == sube).OrderByDescending(a => a.Notlar.Average()).Take(5).ToList();
                BütünÖğrencileriListele(subeOgrencileri);
        }

        public void ŞubedekiEnDüşükNotlu3ÖğrenciyiListele(List<Ogrenci> liste)
        {
                Console.WriteLine("Şube seçiniz (A/B/C): ");
                string subeSecim = Console.ReadLine().ToUpper();
                SUBE sube;
                if (!Enum.TryParse(subeSecim, out sube))
                {
                    Console.WriteLine("Geçersiz şube seçimi.");
                    return;
                }

                var subeOgrencileri = liste.Where(a => a.Sube == sube).OrderBy(a => a.Notlar.Average()).Take(3).ToList();
                BütünÖğrencileriListele(subeOgrencileri);
        }

        public void ÖğrencininNotOrtalamasınıGör(List<Ogrenci> liste)
        {
                Console.WriteLine("Öğrenci No giriniz: ");
                int no;
                if (!int.TryParse(Console.ReadLine(), out no))
                {
                    Console.WriteLine("Geçersiz öğrenci numarası.");
                    return;
                }

                var ogrenci = liste.FirstOrDefault(a => a.No == no);
                if (ogrenci == null)
                {
                    Console.WriteLine("Öğrenci bulunamadı.");
                    return;
                }

                Console.WriteLine($"Öğrenci: {ogrenci.Ad} {ogrenci.Soyad}");
                Console.WriteLine("Not Ortalaması: " + ogrenci.Average());
        }

        public void ŞubeninNotOrtalamasınıGör(List<Ogrenci> liste)
        {
                Console.WriteLine("Şube seçiniz (A/B/C): ");
                string subeSecim = Console.ReadLine().ToUpper();
                SUBE sube;
                if (!Enum.TryParse(subeSecim, out sube))
                {
                    Console.WriteLine("Geçersiz şube seçimi.");
                    return;
                }

                var subeOgrencileri = liste.Where(a => a.Sube == sube).ToList();
                Console.WriteLine("Şubenin Not Ortalaması: " + subeOgrencileri.Average(a => a.Notlar.Average()));
        }

        public void ÖğrencininOkuduğuSonKitabıGör(List<Ogrenci> liste)
        {
                Console.WriteLine("Öğrenci No giriniz: ");
                int no;
                if (!int.TryParse(Console.ReadLine(), out no))
                {
                    Console.WriteLine("Geçersiz öğrenci numarası.");
                    return;
                }

                var ogrenci = liste.FirstOrDefault(a => a.No == no);
                if (ogrenci == null)
                {
                    Console.WriteLine("Öğrenci bulunamadı.");
                    return;
                }

                Console.WriteLine($"Öğrenci: {ogrenci.Ad} {ogrenci.Soyad}");
                Console.WriteLine("Okuduğu Son Kitap: " + ogrenci.Kitaplar.LastOrDefault());
        }

        public void OgrenciEkle(List<Ogrenci> liste)
        {
                Console.WriteLine("Öğrenci No: ");
                int no = int.Parse(Console.ReadLine());
                Console.WriteLine("Ad: ");
                string ad = Console.ReadLine();
                Console.WriteLine("Soyad: ");
                string soyad = Console.ReadLine();
                Console.WriteLine("Şube (A/B/C): ");
                SUBE sube = (SUBE)Enum.Parse(typeof(SUBE), Console.ReadLine().ToUpper());
                Console.WriteLine("Cinsiyet (Kiz/Erkek): ");
                CINSIYET cinsiyet = (CINSIYET)Enum.Parse(typeof(CINSIYET), Console.ReadLine());

                var ogrenci = new Ogrenci(no, ad);
                liste.Add(ogrenci);

                Console.WriteLine("Öğrenci eklendi.");
        }

        public void ÖğrenciGüncelle(List<Ogrenci> liste)
        {
                Console.WriteLine("Güncellenecek Öğrenci No: ");
                int no = int.Parse(Console.ReadLine());

                var ogrenci = liste.FirstOrDefault(a => a.No == no);
                if (ogrenci == null)
                {
                    Console.WriteLine("Öğrenci bulunamadı.");
                    return;
                }

                Console.WriteLine("Yeni Ad: ");
                ogrenci.Ad = Console.ReadLine();
                Console.WriteLine("Yeni Soyad: ");
                ogrenci.Soyad = Console.ReadLine();
                Console.WriteLine("Yeni Şube (A/B/C): ");
                ogrenci.Sube = (SUBE)Enum.Parse(typeof(SUBE), Console.ReadLine().ToUpper());
                Console.WriteLine("Yeni Cinsiyet (Kiz/Erkek): ");
                ogrenci.Cinsiyet = (CINSIYET)Enum.Parse(typeof(CINSIYET), Console.ReadLine());

                Console.WriteLine("Öğrenci güncellendi.");
        }

        public void ÖğrenciSil(List<Ogrenci> liste)
        {
                Console.WriteLine("Silinecek Öğrenci No: ");
                int no = int.Parse(Console.ReadLine());

                var ogrenci = liste.FirstOrDefault(a => a.No == no);
                if (ogrenci == null)
                {
                    Console.WriteLine("Öğrenci bulunamadı.");
                    return;
                }

                liste.Remove(ogrenci);
                Console.WriteLine("Öğrenci silindi.");
        }

        public void ÖğrencininAdresiniGir(List<Ogrenci> liste)
        {
                Console.WriteLine("Öğrenci No: ");
                int no = int.Parse(Console.ReadLine());

                var ogrenci = liste.FirstOrDefault(a => a.No == no);
                if (ogrenci == null)
                {
                    Console.WriteLine("Öğrenci bulunamadı.");
                    return;
                }

                Console.WriteLine("Yeni Adres: ");
                ogrenci.Adres = Console.ReadLine();

                Console.WriteLine("Adres güncellendi.");
        }

        public void ÖğrencininOkuduğuKitabıGir(List<Ogrenci> liste)
        {
                Console.WriteLine("Öğrenci No: ");
                int no = int.Parse(Console.ReadLine());

                var ogrenci = liste.FirstOrDefault(a => a.No == no);
                if (ogrenci == null)
                {
                    Console.WriteLine("Öğrenci bulunamadı.");
                    return;
                }

                Console.WriteLine("Kitap Adı: ");
                ogrenci.Kitaplar.Add(Console.ReadLine());

                Console.WriteLine("Kitap eklendi.");
        }

        public void ÖğrencininNotunuGir(List<Ogrenci> liste)
        {
                Console.WriteLine("Öğrenci No: ");
                int no = int.Parse(Console.ReadLine());

                var ogrenci = liste.FirstOrDefault(a => a.No == no);
                if (ogrenci == null)
                {
                    Console.WriteLine("Öğrenci bulunamadı.");
                    return;
                }

                     Console.WriteLine("Not: ");
                     ogrenci.Notlar.Add(int.Parse(Console.ReadLine()));

                     Console.WriteLine("Not eklendi.");
        }
        
        //public void VeriEkle(List<Ogrenci> liste)
        //{

        //}


    }
    }






































    //        public void CinsiyetineGöreÖğrencileriListele(List<Ogrenci> liste)
    //{

    //}

    //public void ŞuTarihtenSonraDoğanÖğrencileriListele(List<Ogrenci> liste)
    //{

    //}

    //public void İllereGöreSıralayarakÖğrencileriListele(List<Ogrenci> liste)
    //{

    //}

    //public void ÖğrencininTümNotlarınıListele(List<Ogrenci> liste)
    //{

    //}

    //public void ÖğrencininOkuduğuKitaplarıListele(List<Ogrenci> liste)
    //{

    //}

    //public void OkuldakiEnYüksekNotlu5ÖğrenciyiListele(List<Ogrenci> liste)
    //{

    //}

    //public void OkuldakiEnDüşükNotlu3ÖğrenciyiListele(List<Ogrenci> liste)
    //{

    //}


    //public void ŞubedekiEnYüksekNotlu5ÖğrenciyiListele(List<Ogrenci> liste)
    //{

    //}

    //public void ŞubedekiEnDüşükNotlu3ÖğrenciyiListele(List<Ogrenci> liste)
    //{

    //}

    //public void ÖğrencininNotOrtalamasınıGör(List<Ogrenci> liste)
    //{

    //}
    //public void ŞubeninNotOrtalamasınıGör(List<Ogrenci> liste)
    //{

    //}

    //public void ŞubeniNotOrtalamasınıGör(List<Ogrenci> liste)
    //{

    //}

    //public void ÖğrencininOkuduğuSonKitabıGör(List<Ogrenci> liste)
    //{

    //}
    //public void ÖğrenciEkle(List<Ogrenci> liste)
    //{

    //}
    //public void ÖğrenciGüncelle(List<Ogrenci> liste)
    //{

    //}
    //public void ÖğrenciSil(List<Ogrenci> liste)
    //{

    //}
    //public void ÖğrencininAdresiniGir(List<Ogrenci> liste)
    //{

    //}
    //public void ÖğrencininOkuduğuKitabıGir(List<Ogrenci> liste)
    //{

    //}

    //public void ÖğrencininNotunuGir(List<Ogrenci> liste)
    //{

    //}


























