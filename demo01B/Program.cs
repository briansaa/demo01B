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
            persona.nombre = "brian ";
            persona.apellidos = "saavedra";
            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);

            persona persona1 = new persona("viper", "saa");
            persona persona2 = new persona
            { 
NombresCompletos = ""            
            }
            Console.WriteLine("hola mundo");

                Console.Read();
        }
    }
}
