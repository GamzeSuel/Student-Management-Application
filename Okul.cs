using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_TP115_Temel
{
    internal class Okul
    {
        public Okul() 
        {
            OgrenciEkle();
        }
        //Öğrenci Ekle
        //Öğrenci Sil
        //Kitap Gir

        //Okul'a ait herhangi bir verinin değiştirilmesi işlemi bu sınıfta gerçekleştirilecek.

        List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public void OgrenciEkle(int no, string ad, string soyad, DateTime dogumTarihi, SUBE sube, CINSIYET cinsiyet, string Il )
        {
            Ogrenci o = new Ogrenci();

            o.No = no;
            o.Ad = ad;
            o.Soyad = soyad;
            o.DogumTarihi = dogumTarihi;    
            o.Sube = sube;
            o.Adresi.Il = Il;
            o.Cinsiyet = cinsiyet;
            


            //diğer bilgiler eklenecek.

            this.ogrenciler.Add(o);
        }

        public void NotEkle(int no, string dersAdi, int not)
        {
            Ogrenci o = this.ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
            {
                o.Notlar.Add(new DersNotu(dersAdi, not));
            }
        }

        
        
    }
}
