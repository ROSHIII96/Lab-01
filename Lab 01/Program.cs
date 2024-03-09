// Creamos una lista de animales y llamamos al método HacerSonido de cada uno de ellos
using Lab_01.Poliformismo;

public class Program
{
    static void Main(string[] args)
    {
        // Creamos una lista de animales
        HerenciaAnimal[] animales = new HerenciaAnimal[3];
        animales[0] = new Perro();
        animales[1] = new Pollo();
        animales[2] = new Pato();

        // Llamamos al método HacerSonido de cada animal
        foreach (HerenciaAnimal animal in animales)
        {
            animal.SonidoAnimal();
        }
    }
}