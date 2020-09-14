//Práctica 4 Ejercicio 2.
//Nota : Programa capaz de mostrar una clase llamada Estudiante
//       y esta tendra un campo llamdo promedio y no sobre pasa
//       la nota de 100 pts.
//
// 
//                                        © Anthony Reyes Duran

using System;

namespace Practica4e2
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante(97, 89);
            estudiante.CalcularPromedio();
            estudiante.MostrarPromedio();
        }
    }
}
