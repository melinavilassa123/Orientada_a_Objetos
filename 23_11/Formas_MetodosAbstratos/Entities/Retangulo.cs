using Formas_MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formas_MetodosAbstratos.Entities
{
    class Retangulo : Forma
    {
        
        public double Largura { get; set; }
        public double Altura { get; set; }

        
        public Retangulo(double largura, double altura, Color color) : base(color)
        {
            Largura = largura;
            Altura = altura;
        }

        
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
