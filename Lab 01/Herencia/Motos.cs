using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Herencia
{
    public class Motos : Vehiculo
    {
        Motos() 
        {
            this.Id = 1;
            this.Marca = "FREEDOM";
            this.Modelo = "ZS MIEDO";
            this.TipoGasolina = "Super";
            this.Precio = 1500000;
            this.YearBuy = 2024;
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
