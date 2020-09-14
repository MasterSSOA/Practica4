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
    class Persona
    {
        private string _Nombre;
        private string _Estatura;
        private int _Edad;

        public Persona(string Nombre, string Estatura, int Edad)
        {
            _Nombre = Nombre;
            _Estatura = Estatura;
            _Edad = Edad;
        }
        public void Display()
        {
            Console.WriteLine("Su Nombre es {0} mide {1} y tiene {2} años.\n", _Nombre, _Estatura, _Edad);
        }
    }

    class Carro
    {
        private string _Marca;
        private string _Modelo;
        private string _Color;

        public Carro(string Marca, string Modelo, string Color)
        {
           _Marca = Marca;
           _Modelo = Modelo;
           _Color = Color;
        }
        public void Display()
        {
            Console.WriteLine("El Carro es de marca {0} modelo {1} y de color {2}.\n", _Marca, _Modelo, _Color);
        }
    }

    class Casa
    {
        private string _Color;
        private int _NumeroHabitaciones;
        private double _MetrosCuadrados;
        

        public Casa(string Color, int NumeroHabitaciones, double MetrosCuadrados)
        {
            _Color = Color;
            _NumeroHabitaciones = NumeroHabitaciones;
            _MetrosCuadrados = MetrosCuadrados;
        }

        public void Display()
        {
            Console.WriteLine("La Casa es de color {0} de {1} habitacion(es) y posee una dimenension de {2} " +
                              "metros cuadrados.\n", _Color, _NumeroHabitaciones, _MetrosCuadrados);
        }
    }
}
