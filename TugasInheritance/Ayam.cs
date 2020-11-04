using System;

namespace TugasInheritance
{
    public class Ayam : Unggas
    {
        private string ciriciri = "Tidak dapat terbang";

        public void info()
        {
            Console.WriteLine("Cara ayam berkembangbiak : " + base.berkembangbiak);
            Console.WriteLine("Jumlah sayap ayam : " + base.Sayap);
            Console.WriteLine("Ciri-ciri ayam : " + this.ciriciri);

        }
    }
}
