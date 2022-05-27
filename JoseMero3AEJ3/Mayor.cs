using System;
using System.Collections.Generic;
using System.Text;

namespace JoseMero3AEJ3
{
    public class Mayor
    {
        private int valorA { set; get; }
        private int valorB { set; get; }
        private int valorC { set; get; }

        public Mayor(int valorA, int valorB, int valorC)
        {
            this.valorA = valorA;
            this.valorB = valorB;
            this.valorC = valorC;
        }
        public void proceso()
        {
            if (valorA > valorB && valorA > valorC)
            {
                Console.WriteLine("El numero " + valorA + " es mayor");
            }
            else if (valorB > valorA && valorB > valorC)
            {
                Console.WriteLine("El numero " + valorB + " es mayor");
            }
            else
            {
                Console.WriteLine("El numero " + valorC + " es mayor");
            }
            Console.ReadKey();
        }
    }
}

