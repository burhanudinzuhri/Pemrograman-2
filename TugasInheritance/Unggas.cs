using System;

namespace TugasInheritance
{
    public class Unggas
    {
        protected string berkembangbiak = "bertelur";
        public int Sayap = 2;

        public void info()
        {
            Console.WriteLine("Sayap Ayam berjumlah : " + this.Sayap);
            Console.WriteLine("Cara berkembangbiak ayam : " + this.berkembangbiak);

        }

    }
    
}