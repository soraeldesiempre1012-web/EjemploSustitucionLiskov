using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploSustitucionLiskov
{
    public abstract class Ave
    {
        public double Peso { get; set; }
        public double Edad { get; set; }
        public abstract string TipoDeAve();
    }
}

// Este es un comentario.
