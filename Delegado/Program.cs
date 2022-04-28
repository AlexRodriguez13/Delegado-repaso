using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegado
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isPrimoOrNot = delegate (int Numero)
          {
              int cont = 0;
              for (int i = 1; i <= Numero; i++)
              {
                  if (Numero % i == 0)
                  {
                      cont++;

                  }

              }
              if (cont == 2)
              {
                  return true;
              }
              else
              {
                  return false;
              }
          };


            int[] Numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = 0;

            for (int i= 0 ;i < Numeros.Length;i++)
            {
                if (isPrimoOrNot(Numeros[i]))
                {
                    Console.WriteLine($"Indice: {index} y su numero {Numeros[i]} " );
                    index++;
                }

            }

            for(int i = 0; i <= Numeros.Length; i++)
            {
                if (isPrimoOrNot(Numeros[i]) == false)
                {
                    Console.WriteLine($"Indice {index} y su numero {Numeros[i]} ");

                }
                Console.ReadLine();
            
            }


        }
    }
}
