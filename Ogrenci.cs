using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_TP115_Temel
{
    internal class Ogrenci
    {
        public int No;
        public string Ad;
        public string Soyad;
        public DateTime DogumTarihi;  //Get ve Set özelliği tanımlayabilirsiniz.
        public float Ortalama;
        public SUBE Sube;
        public CINSIYET Cinsiyet;
        public Adres Adresi;

        public List<string> Kitaplar = new List<string>();

        public List<DersNotu> Notlar = new List<DersNotu>();
        public List<SUBE>Şube = new List<SUBE>();

        public Ogrenci(int no,string ad,string soyad, SUBE sube, CINSIYET cinsiyet)
        {
           this.No = no;
           this.Ad = ad;   
                
        }

    }

    public enum SUBE
    {
        Empty,A,B,C
    }

    public enum CINSIYET 
    {
        Empty,Kiz,Erkek
    }
    public enum ADRES

    {
        Empty,istanbul,Ankara,İzmir,Konya,Bursa,Adana,Antalya
    }


}
