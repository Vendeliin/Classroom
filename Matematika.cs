using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Matematika
    {
        public double pi = 3.14;
        public double r;
        public Matematika(double _r)
        {
            Console.WriteLine("Jaky je polomer kruhu v cm: ");
            _r = Convert.ToDouble(Console.ReadLine());
            r = _r;
        }
        public void Obvod()
        {
            Console.WriteLine("Obvod kruhu je: " + r * (2 * pi) + " cm.");
        }
        public void Obsah()
        {
            Console.WriteLine("Obsah kruhu je: " + pi*(r*r) + " cm^2.");
        }
    }
}
