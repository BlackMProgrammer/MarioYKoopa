using System;

namespace MarioYKoopa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comandos de Mario: ");

            Mario mario1 = new Mario();
            mario1.MoverAbajo();
            mario1.MoverDerecha();
            mario1.MoverIzquierda();
            mario1.MoverArriba();

            Console.WriteLine("\nComandos de Koopa: ");
            Koopa koopa1 = new Koopa();
            koopa1.MoverArriba();
            koopa1.MoverAbajo();
            koopa1.MoverDerecha();
            koopa1.MoverIzquierda();
        }
    }
}
