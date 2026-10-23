using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenPOO.Ejercicios
{
    public class Ejercicic3
    {
        public void Asistencia()
        {
            string[] nombres = {"Pedro", "Juan", "Pablo", "Maria", "Mateo", "Magdalena","Daniela","Dulce","Hector","Emilio"};
            bool[] asistencia = new bool[10];
            int si=0;
            int  no=0;
            for(int i=0;i<nombres.Length;i++)
            {
                Console.WriteLine($"Asistencia {nombres[i]}(si/no");
                string asistio = Console.ReadLine();
                if(asistio=="si"||asistio=="SI"||asistio=="Si")
                {
                    asistencia[i]=true;
                    si++;
                }
                else if(asistio=="no"||asistio=="NO"||asistio=="No")
                {
                    asistencia[i]=false;
                    no++;
                }
                else
                {
                    Console.WriteLine($"Repitalo porfavot");
                    i--;
                }
                double porcentaje = (si/10)*100;
                Console.WriteLine($"Asisitieron {si}; Faltaron {no}"); 
                Console.WriteLine($"El porcentaje de asistencia es de: {porcentaje}%");

                foreach(bool item in asistencia)
                {
                    i=0;
                    if(item==false)
                    {
                        Console.WriteLine($"El estudante {nombres[i]} falto");
                    }
                    i++;
                }
                Console.WriteLine("Ingrese el nombre de un estudiante para buscar");
                string busqueda = Console.ReadLine();
                for(int j=0;j<nombres.Length;j++)
                {
                    if(nombres[j]==busqueda)
                    {
                        Console.WriteLine($"El nombre fue encontrado\n Posicion:{j+1}");
                        if(asistencia[j]==true)
                        {
                            Console.WriteLine("Asisitio a clase");
                        }
                        else
                        {
                            Console.WriteLine("No asisitio");
                        }
                    }
                    else
                    {
                         Console.WriteLine("Registro no encontrado");
                    }
                }
                Console.WriteLine("Registro de Estudiantes invertido");
                for(int k=nombres.Length;k>=0;k--)
                {
                    Console.WriteLine($"{nombres[k]}");
                }
            }
        }
    }
}