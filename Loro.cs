using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploSustitucionLiskov
{
    public class Loro : Ave
    {
        public override string TipoDeAve() => "Loro";
        public void Volar()
        {
            Console.WriteLine("El loro está volando");
        }
    }
}

// Este es un comentario.
