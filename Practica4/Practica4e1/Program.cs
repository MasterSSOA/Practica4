//Práctica 4 Ejercicio 1.
//Nota : Programa capaz de ver tres entidades reales, con mínimo tres 
//       de características diferentes.
//
// 
//                                              © Anthony Reyes Duran

using System;

namespace Practica4e1
{
    //Lógica del Programa.
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrando entidad Persona.
            Persona persona = new Persona("Anthony", "6ft", 23);
            Console.WriteLine("ENTIDAD PERSONA");
            persona.Display();

            //Mostrando entidad Carro.
            Carro carro = new Carro("Mercedes Benz", "C300", "Blanco");
            Console.WriteLine("ENTIDAD CARRO");
            carro.Display();

            //Mostrando entidad Casa.
            Casa Casa = new Casa("Blanco", 4, 240);
            Console.WriteLine("ENTIDAD CASA");
            Casa.Display();

            Console.ReadKey();
        }
    }

    //Entidades del Mundo Real.
    public class Persona
    {
        public string Nombre;
        public string Estatura;
        public int Edad;

        public Persona(string Nombre, string Estatura, int Edad)
        {
            this.Nombre = Nombre;
            this.Estatura = Estatura;
            this.Edad = Edad;
        }
        public void Display()
        {
            Console.WriteLine("Su Nombre es {0} mide {1} y tiene {2} años.\n", Nombre, Estatura, Edad);
        }
    }

    public class Carro
    {
        public string Marca;
        public string Modelo;
        public string Color;

        public Carro(string Marca, string Modelo, string Color)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Color = Color;
        }
        public void Display()
        {
            Console.WriteLine("El Carro es de marca {0} modelo {1} y de color {2}.\n", Marca, Modelo, Color);
        }
    }

    public class Casa
    {
        public string Color;
        public int NumeroHabitaciones;
        public double MetrosCuadrados;
        

        public Casa(string Color, int NumeroHabitaciones, double MetrosCuadrados)
        {
            this.Color = Color;
            this.NumeroHabitaciones = NumeroHabitaciones;
            this.MetrosCuadrados = MetrosCuadrados;
        }

        public void Display()
        {
            Console.WriteLine("La Casa es de color {0} de {1} habitacion(es) y posee una dimenension de {2} " +
                              "metros cuadrados.\n", Color, NumeroHabitaciones, MetrosCuadrados);
        }
    }
}
