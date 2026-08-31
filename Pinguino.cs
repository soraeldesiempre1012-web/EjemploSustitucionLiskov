using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploSustitucionLiskov
{
    public class Pinguino : Ave
    {
        public override string TipoDeAve() => "Pinguino";
        public void Nadar()
        {
            Console.WriteLine("El pinguino está nadando");
        }
    }
}

// Este es un comentario.
