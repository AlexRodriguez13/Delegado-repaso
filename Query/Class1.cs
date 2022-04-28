using Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Query
{
    public class Class1
    {
        static void main (string[] args)
        {
            List<Persona> ListadoPersonas = new List<Persona>
            {
                new Persona() {Nombre = "Juan" , Apellido = "Morales", Edad =18 },
                new Persona() {Nombre = "Luis" , Apellido = "Campo", Edad =18 },
                new Persona() {Nombre = "Ronnie" , Apellido = "Perez", Edad =18 }
            };

            var listadoConFiltro = from item in ListadoPersonas where item.Edad > 18 select item;

        }


    }
}
