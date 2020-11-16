using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_24
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration
            double température, min, max;

            // saisi de la première température 
            Console.Write(" température n°1 = ");
            min=max = double.Parse(Console.ReadLine());

            // boucle sur les 10 température
            for (int k = 2; k <= 10; k++)
            {
                // saisi des température 
                Console.Write(" température n°" +k+ " = ");
                température = double.Parse(Console.ReadLine());

                // recherche de la température minimale et max
                if (température < min)
                {
                    min = température;
                }
                if (température > max)
                {
                    max = température;
                }


            }
            // affichage de la température min et max
            Console.WriteLine(" la plus petite température est =" + min);
            Console.WriteLine(" la plus grande température est =" + max);

            Console.ReadLine();
            
            
        }
    }
}
