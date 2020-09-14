//Práctica 4 Ejercicio 4.
//Nota : Sobrecargando los metodos de sumas y resta... del
//       ejercicio 3 práctica 4 con 2, 3 y 4 números.
//
// 
//                                         © Anthony Reyes Duran

using System;

namespace Practica4e4
{
    class Aritmetica
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma con 2 números: {0}", Aritmetica.Sumar(10, 12));
            Console.WriteLine("Suma con 3 números: {0}", Aritmetica.Sumar(Aritmetica.Sumar(10, 12), 15));
            Console.WriteLine("Suma con 4 números: {0}", Aritmetica.Sumar(Aritmetica.Sumar(Aritmetica.Sumar(10, 12), 15), 19));

            Console.WriteLine("Resta con 2 números: {0}", Aritmetica.Sumar(100, 50));
            Console.WriteLine("Resta con 3 números: {0}", Aritmetica.Sumar(Aritmetica.Sumar(100, 50), 10));
            Console.WriteLine("Resta con 4 números: {0}", Aritmetica.Sumar(Aritmetica.Sumar(Aritmetica.Sumar(100, 50), 10), 5));
            
            Console.ReadKey();
        }

        //Métodos Básicos de Aritméticas.
        private static double Sumar(double _Number1, double _Number2)
        {
            double _Total = _Number1 + _Number2;
            return _Total;
        }
        private static double Restar(double _Number1, double _Number2)
        {
            double _Total = _Number1 - _Number2;
            return _Total;
        }
        private static double Dividir(double _Number1, double _Number2)
        {
            double _Total = _Number1 / _Number2;
            return _Total;
        }
        private static double Multiplicar(double _Number1, double _Number2)
        {
            double _Total = _Number1 * _Number2;
            return _Total;
        }
    }
}
