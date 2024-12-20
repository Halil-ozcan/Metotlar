using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Ogrenci
    {
        public void selamla()
        {
            Console.WriteLine("Merhaba");

            
        }

        public void OgrenciMetot(string OgrenciAd, string OgrenciSoyad)
        {
            Console.WriteLine("{0} - {1}", OgrenciAd, OgrenciSoyad);
        }
    }
}
