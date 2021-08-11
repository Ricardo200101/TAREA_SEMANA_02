using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_SEMANA_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables. 

            int estudiantes;

            // DECLARACION DEL TAMAÑO DEL ARREGLO. 
            do
            {
                Console.WriteLine("INGRESE EL NUMERO DE ESTUDIANTE QUE DESEA PROMEDIAR: ");
                estudiantes = Convert.ToInt32(Console.ReadLine());
            } while (estudiantes <= 0);

            string[] arreglo = new string [estudiantes]; 

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(" "); 
                Console.WriteLine("INGRESAR NOMBRE DEL ESTUDIANTE {0}: " ,i);
                arreglo [0] = Console.ReadLine();
                Console.WriteLine(" ");

                // Solicitar notas del estudiante. 

                double[] notas = new double[4]; 

                for (int j = 1; j < notas.Length; j++)
                {
                    

                    Console.WriteLine("INGRESAR NOTA {0}: ",j);
                    notas[0] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" ");
                    

                }

                double nota1 = notas[0] * 30 / 100;
                double nota2 = notas[1] * 35 / 100;
                double nota3 = notas[2] * 25 / 100;
                double notaf = nota1 + nota2 + nota3; 

                Console.WriteLine("LA NOTA FINAL DEL ESTUDIANTE, {0}{1}",arreglo[0]," ES: ",notaf); 
            }
      
            Console.ReadKey(); 
        }
    }
}
