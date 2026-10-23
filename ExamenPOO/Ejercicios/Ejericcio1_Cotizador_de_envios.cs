using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenPOO.Ejercicios
{
    public class Ejericcio1_Cotizador_de_envios
    {
      public void Cotizador()
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese a que tipo de zona desea enviar");
            Console.WriteLine("1. Zona local");
            Console.WriteLine("2. Zona departamental");
            Console.WriteLine("3. Zona nacional");
            int opZona, opservicio;
            while(!int.TryParse(Console.ReadLine(), out opZona)||opZona<1||opZona>3)
            {
                Console.WriteLine("Numero invalido,intentelo otravez");
            }
            Console.WriteLine("Ingrese el peso del paquete en kg");
            double kg, L;
            while(!double.TryParse(Console.ReadLine(), out   kg)||kg<=0)
            {
                Console.WriteLine("Numero invalido,intentelo otravez");
            }
            Console.WriteLine("Ingrese a que tipo de servicio que desea");
            Console.WriteLine("1. normal");
            Console.WriteLine("2. express");
            Console.WriteLine("3. mismo dia");
            while(!int.TryParse(Console.ReadLine(), out opservicio)||opservicio<1||opservicio>3)
            {
                Console.WriteLine("Numero invalido,intentelo otravez");
            }
            Console.WriteLine("Ingrese el valor del paquete en L");
            while(!double.TryParse(Console.ReadLine(), out  L)||L<=0)
            {
                Console.WriteLine("Numero invalido,intentelo otravez");
            }
            double precioEnvio=0;
            switch(opZona)
            {
                case 1: precioEnvio=60;
                break;
                case 2: precioEnvio=100;
                break;
                case 3: precioEnvio=150;
                break;
            }
            string recargo="";
            if(kg>10)
            {
                precioEnvio+=140;
                recargo="140";
            }
            else if(kg>5)
            {
                precioEnvio+=100;
                recargo="100";
            }
            else if(kg>1)
            {
                precioEnvio+=40;
                recargo="40";
            }

            double ExtraServ=0;
            string serv="";
            switch(opservicio)
            {
                case 1: ExtraServ=0;
                serv = "Estandar";
                break;
                case 2: ExtraServ=0.25;
                serv="expres";
                break;
                case 3: ExtraServ=0.50;
                serv="Un solo dia";
                break;
            }
            double total;
            if(L>5000)
            {
                precioEnvio= precioEnvio+(L*0.2);
            }
            if(precioEnvio>700)
            {
                precioEnvio= precioEnvio-(precioEnvio*0.02);
            }
            total  = precioEnvio+(precioEnvio*ExtraServ);
            string mensaje = L>5000 ? "Esta asegurado" : "No esta asegurado";
            Console.WriteLine($"El subtotal es de {precioEnvio:F2}L");
            Console.WriteLine($"Kg: {kg:F2} con un recargo de{recargo:F2}");
            Console.WriteLine($"Valor del paquete:{L:F2} L \n {mensaje}");
            Console.WriteLine($"El servivio es de tipo{serv}");
            Console.WriteLine($"TOTAL {total:F2}L");
        }   
    }
}