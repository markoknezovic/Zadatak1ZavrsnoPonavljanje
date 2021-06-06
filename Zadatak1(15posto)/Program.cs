using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string unesi, sVelika, sMala, sPrvaTri, sZadnjihPet, s8_11;
            Console.Write("Upisi nesto: ");
            unesi = Console.ReadLine();
            
            sVelika = unesi.ToUpper();
            Console.WriteLine(sVelika);

            sMala = unesi.ToLower();
            Console.WriteLine(sMala);

            sPrvaTri = unesi.Substring(0, 3);
            Console.WriteLine(sPrvaTri);

            sZadnjihPet = unesi.Substring(unesi.Length - 5);
            Console.WriteLine(sZadnjihPet);

            s8_11 = unesi.Substring(7, 4);
            Console.WriteLine(s8_11);

            Console.ReadKey();

        }
    }
}