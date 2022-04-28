using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persona;

namespace Lambda
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //Action<string> Saludo1 = cadena =>
            //{
            //    Console.WriteLine($"Hola {cadena} ");
            //};
            //Saludo1("Pedro");

            //Action<string, string> Saludo2 = (cadena1, cadena2) =>
            //{
            //    Console.WriteLine($"Hola {cadena1}, {cadena2} ");
            //};
            //Saludo2("Juan", "Martinez");


            List<int> ListadoNumero = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ListadoNumero.ForEach(numerito =>
            {
                if (numerito % 2 == 0)
                {
                    Console.WriteLine(numerito);
                }
            });


            List<Persona0> ListadoSinFiltro = new List<Persona0>
            {
                new Persona0() {Nombre = "Juan", Apellido = "Martinez", Edad= 18},
                new Persona0() {Nombre = "Oscar", Apellido = "Garcia", Edad= 18},
                new Persona0() {Nombre = "Cesar", Apellido = "Vivas", Edad= 18}
            };

            //foreach (var item in ListadoSinFiltro.Where(Object=> Object.Edad>18))
            //{
            //    Console.WriteLine(item.Nombre);
            //}

            var ListadoConFiltro = ListadoSinFiltro.Where(x => x.Apellido.Contains("M"));

            foreach(var item in ListadoConFiltro)
            {
                Console.WriteLine(item.Nombre);
            }

            Console.ReadLine();
        }

    }
}
