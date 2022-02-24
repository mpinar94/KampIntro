using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {//naming Convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler .Sepete Eklendi " +urun.Adı);
        }

        public void Ekle2(string urununAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler .Sepete Eklendi " + urununAdi);
        }

    }
}
