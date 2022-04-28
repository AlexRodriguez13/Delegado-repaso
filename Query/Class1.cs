using Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Query
{
     class Class1
    {
        static void main (string[] args)
        {
            List<Persona0> ListadoPersonas = new List<Persona0>
            {
                new Persona0() {Nombre = "Juan" , Apellido = "Morales", Edad =18 },
                new Persona0() {Nombre = "Luis" , Apellido = "Campo", Edad =18 },
                new Persona0() {Nombre = "Ronnie" , Apellido = "Perez", Edad =18 }
            };

            var listadoConFiltro = from item in ListadoPersonas where item.Edad > 18 select item;

            foreach(var item in listadoConFiltro)
            {
                Console.WriteLine($"{item.Nombre}, {item.Apellido} ");
            }
            Console.ReadLine();

        }


    }
}
