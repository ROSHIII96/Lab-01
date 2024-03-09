using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Herencia
{
    public class Carro : Vehiculo
    {
        Carro()
        {
            this.Id = 2;
            this.Marca = "Toyota";
            this.Modelo = "Jailuz";
            this.TipoGasolina = "Premium";
            this.Precio = 10000;
            this.YearBuy = 2015;
        }
        public void MostrarDatos()
        {
            Console.WriteLine(this.Id);
            Console.WriteLine(this.Marca);
            Console.WriteLine(this.Modelo);
            Console.WriteLine(this.TipoGasolina);
            Console.WriteLine(this.Precio);
            Console.WriteLine(this.YearBuy);
        }
    }
}
