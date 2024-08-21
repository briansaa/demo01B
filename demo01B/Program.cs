using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01B
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            persona persona = new persona();
            persona.nombre = "Brian";
            persona.apellidos = "Saavedra";
            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);

            persona persona1 = new persona("Viper", "Saa");

            persona persona2 = new persona
          

              estudiante estudiante = new estudiante
              {

                 nombres = "brian",
                 apellidos = " saavedra",
                  Nota = 20
                    
              };
            /*
             
             
             */





            Console.WriteLine("hola mundo");

                Console.Read();


      
        }
    }
}
