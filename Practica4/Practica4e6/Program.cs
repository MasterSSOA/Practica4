//Práctica 4 Ejercicio 6.
//Nota : Programa capaz contener una clase llamada carro y real-
//       izar las peticiones denfidas en la práctica.
//
// 
//                                         © Anthony Reyes Duran

using System;

namespace Practica4e6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamando el Método Encender Con Un Carro Con Gasolina...
            Console.WriteLine("EJEMPLO CARRO CON GASOLINA");
            Carro CarroConGasolina = new Carro(7);
            CarroConGasolina.Encender();
            CarroConGasolina.Encender();

            //Llamando el Método Encender Con Un Carro Sin Gasolina...
            Console.WriteLine("\nEJEMPLO CARRO SIN GASOLINA");
            Carro CarroSinGasolina = new Carro(0);
            CarroSinGasolina.Encender();

            Console.ReadKey();
        }
    }

    //Clase Carro.
    class Carro
    {
        //Atributos.
        private double _cantidadCombustible;

        //Constructor.
        public Carro(double cantidadCombustible)
        {
            _cantidadCombustible = cantidadCombustible;
        }
        //Métodos.
        public void Encender()
        {
            if (_cantidadCombustible <= 0)
            {
                Console.WriteLine("\nEl Carro No Pudo Avanzar Debido A Falta De Gasolina...");
            }
            else
            {
                _cantidadCombustible -= 1;
                Console.WriteLine("\nEl Carro Pudo Avanzar...");
                Console.WriteLine("Combustible Restante Es {0}", _cantidadCombustible);
            }
        }
    }
}
