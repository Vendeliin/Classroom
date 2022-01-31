using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Chameleon
    {
        public string _name;
        public string _color;
        public Chameleon(string name, string color, int height, int lenght, int weight)
        {
            Console.WriteLine("Jmeno chameleona:");
            name = Console.ReadLine();
            _name = name;
            Console.WriteLine("Barva chameleona:");
            color = Console.ReadLine();
            _color = color;
            Console.WriteLine("Vyska chameleona:");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Delka chameleona:");
            lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vaha  chameleona:");
            weight = Convert.ToInt32(Console.ReadLine());
        }
        public void Lovit()
        {
            Console.WriteLine(_name + ": SLURP!");
        }
        public void changeColor()
        {
            Console.WriteLine("Na jakou barvu se zmnění chameleon?");
            _color = Console.ReadLine();
            Console.WriteLine(_name + " " + _color);
        }

    }
}
