using Formas_MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formas_MetodosAbstratos.Entities
{
    
    abstract class Forma
    {
        
        public Color Color { get; set; }
        
        
        public Forma (Color color)
        {
            Color = color;
        }

       
        public abstract double Area();
    }
}
