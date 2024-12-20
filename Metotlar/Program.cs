using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();

            ogrenci.selamla();

            ogrenci.OgrenciMetot("Halil", "Özcan");
        }
    }
}
