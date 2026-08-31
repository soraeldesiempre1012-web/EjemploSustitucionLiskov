using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploSustitucionLiskov
{
    public class Avestruz : Ave
    {
        public override string TipoDeAve() => "Avestruz";
        public void correr()
        {
            Console.WriteLine("La avstruz está corriendo");
        }
    }
}
