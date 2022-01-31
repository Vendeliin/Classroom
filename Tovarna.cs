using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Tovarna
    {
        public string product;
        public Tovarna(string _product)
        {
            Console.WriteLine("Jaky produkt chces vytvorit");
            _product = Console.ReadLine();
            product = _product;
        }

        public void Make1()
        {
            Console.WriteLine("\n" + product + " byl vytvoren");
            Console.WriteLine("------");
        }
        public void Make2(int _num)
        {
            Console.WriteLine("Kolikrat chces vyrobyt produkt");
            _num = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 0; i < _num; i++)
            {
                Console.WriteLine(product);
            }
        }
    }
}
