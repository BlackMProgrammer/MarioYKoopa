using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace MarioYKoopa
{
    class Personaje
    {
        public Personaje()
        {
            
        }
        public void MoverIzquierda() 
        {
            Console.WriteLine("se movio a la izquierda");
        }

        public void MoverDerecha()
        {
            Console.WriteLine("se movio a la derecha");
        }

        public void MoverArriba()
        {
            Console.WriteLine("se movio hacia arriba");
        }

        public void MoverAbajo()
        {
            Console.WriteLine("se movio hacia abajo");

        }
    }
}
