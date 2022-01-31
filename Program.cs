using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Chameleon chameleon1 = new Chameleon("Lojza", "blue", 4, 15, 200);

            chameleon1.Lovit();
            chameleon1.changeColor();

            Tovarna tovarna1 = new Tovarna("Cihla");

            tovarna1.Make1();
            tovarna1.Make2(5);

            Matematika matematika1 = new Matematika(1);

            matematika1.Obvod();
            matematika1.Obsah();

        }
    }
}
