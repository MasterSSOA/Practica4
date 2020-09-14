using System;

namespace Practica4e2
{
    public class Estudiante
    {
        //Atributos.
        private double _Nota1;
        private double _Nota2;
        private double _Promedio;

        //Constructor.
        public Estudiante(double Nota1, double Nota2)
        {
            if ((1 <= Nota1 && Nota1 <= 100) && (1 <= Nota2 && Nota2 <= 100))
            {
                _Nota1 = Nota1;
                _Nota2 = Nota2;
            } 
            else
            {
                Console.WriteLine("Valor de Notas Incorrectas.");
                Console.ReadKey();
                return;
            }          
        }

        //Métodos
        public double CalcularPromedio()
        {
            _Promedio = (_Nota1 + _Nota2) / 2;
            return _Promedio;
        }
        public void MostrarPromedio()
        {
            Console.WriteLine("Nota Primer Semestre  : {0}\n" +
                              "Nota Segundo Semestre : {1}\n", _Nota1, _Nota2);
            Console.WriteLine("Su promedio de notas es de {0} Puntos.", _Promedio);
            Console.ReadKey();
        }
    }
}
