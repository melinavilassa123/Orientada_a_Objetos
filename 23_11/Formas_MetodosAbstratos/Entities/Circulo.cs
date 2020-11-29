using Formas_MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formas_MetodosAbstratos.Entities
{
    class Circulo : Forma
    {
        
        public double Raio { get; set; }

        
        public Circulo(double raio, Color color) : base(color)
        {
            Raio = raio;
        }

        
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
