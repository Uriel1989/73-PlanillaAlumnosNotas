using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanillaAlumnosNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 30;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Bienvenido a Planilla de alumnos y notas");

            Console.WriteLine("Ingrese la cantidad de alumnos:");

            int CantAlumn = Convert.ToInt32(Console.ReadLine());

            List<Alumno> PlaAlumnos = new List<Alumno>();
            //List<Materia> PlaMaterias = new List<Materia>();


            for ( int i=0; i < CantAlumn; i++)
            {
                Alumno a1 = new Alumno();

                Console.WriteLine("Ingrese el nombre del alumno:");

                a1.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido del alumno:");

                a1.Apellido = Console.ReadLine();

                Console.WriteLine("Ingrese el DNI:");

                a1.DNI = Convert.ToInt32(Console.ReadLine());


                for (int j=0; j <3; j++)
                {
                    int contador = j + 1;
                    Console.WriteLine("Ingrese el nombre de la materia "  + contador);

                    Materia m = new Materia();

                    m.NombMateria =Console.ReadLine();

                    Console.WriteLine("Ingrese las 3 notas de cada materia:");

                    for (int x=0; x<3; x++)
                    {
                        m.notas.Add(Convert.ToDecimal(Console.ReadLine())); //Decimal porque en la case 'MATERIA'
                                                                            //La lista 'NOTA' esta en Decimal

                        
                    }

                    a1.materias.Add(m);
                }
               

                PlaAlumnos.Add(a1);

                Console.Clear();
            }

            for (int i = 0; i < PlaAlumnos.Count; i++)
            {
                Alumno Alumno = PlaAlumnos[i]; //En el objeto 'Alumno' se ha cargado la todo el ciclo de alumnos
                                               // que estaba ingresado en la lista 'PlaAlumnos

                Console.WriteLine("Nombre: " + " " + Alumno.Nombre);
                Console.WriteLine("Apellido:" + " " + Alumno.Apellido);
                Console.WriteLine("DNI:" + " " + " " + Alumno.DNI);

                for (int j=0; j< Alumno.materias.Count; j++) //El objeto 'Alumno' tiene anidado todos los datos
                                                             //En esta intancia es cuestion de invocar el propio
                                                             // a traves de los puntos '.'
                {
                    Materia m = Alumno.materias[j];

                    Console.WriteLine("Nombres de las materias:" + " " + m.NombMateria);
                    for (int x = 0; x< m.notas.Count; x++)
                    {
                        Console.WriteLine("Notas:" + " " + m.notas[x]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
