﻿//Práctica 4 Ejercicio 3.
//Nota : Programa capaz contener una clase llamada Aritmetica 
//       en donde contenga metodos que solo puedan ser accedidos 
//       por la misma clase.
//
// 
//                                         © Anthony Reyes Duran

using System;

namespace Practica4e3
{
    class Aritmetica
    {
        static void Main(string[] args)
        {
            
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
