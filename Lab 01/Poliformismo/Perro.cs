using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Poliformismo
{
    public class Perro : HerenciaAnimal
    {
        public override void SonidoAnimal()
        {
            Console.WriteLine("El perro ladra: ¡Guau guau!");
        }
    }
}
