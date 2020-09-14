//Práctica 4 Ejercicio 5.
//Nota : Programa capaz contener una clase madre y dos clase que
//       hereda las funciones de la misma.
//
// 
//                                         © Anthony Reyes Duran

using System;

namespace Practica4e5
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje.MoverArriba();
            Mario.MoverDerecha();
            Koopa.MoverArriba();
        }
    }

    //Clase Madre.
    class Personaje
    {
        //Atributos.

        //Constructor.

        //Métodos.
        public static void MoverArriba()
        {

        }
        public static void MoverAbajo()
        {

        }
        public static void MoverDerecha()
        {

        }
        public static void MoverIzquierda()
        {

        }
    }

    //Clases Hijo.
    class Mario : Personaje
    {
        //Atributos.

        //Constructor.

        //Métodos.
    }

    class Koopa : Personaje
    {
        //Atributos.

        //Constructor.

        //Métodos.
    }
}
