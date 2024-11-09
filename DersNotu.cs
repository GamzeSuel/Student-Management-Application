using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_TP115_Temel
{
    internal class DersNotu
    {
        public string DersAdi;
        public int Not;

        public DersNotu(string dersAdi, int not)
        {
            this.DersAdi = dersAdi;
            this.Not = not;
        }

        public class Notlar
        {
            private List<int> notlar;

            public Notlar()
            {
                notlar = new List<int>();
            }

            public void NotEkle(int not)
            {
                notlar.Add(not);
            }

            public double Ortalama()
            {
                if (notlar.Count == 0)
                    return 0;

                return notlar.Average();
            }

            public List<int> TumNotlar()
            {
                return new List<int>(notlar);
            }
        }
















    }
}
