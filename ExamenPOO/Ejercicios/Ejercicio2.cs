
namespace ExamenPOO.Ejercicios
{
    public class Ejercicio2
    {
         public void Combustible()
        {
            Console.WriteLine("Ingrese el tipo de combustib;e");
            Console.WriteLine("1. reglar");
            Console.WriteLine("2. premium");
            Console.WriteLine("3. diesel");
            int op;
            while(!int.TryParse(Console.ReadLine(), out op)||op<0||op>3)
            {
                Console.WriteLine("Numero invalido,intentelo otravez");
            }
            Console.WriteLine("Ingrese los litros ue desea");
            int litros;
            while(!int.TryParse(Console.ReadLine(), out litros)||litros<=0||litros>=60)
            {
                Console.WriteLine("Numero invalido,intentelo otravez");
            }
            double precio=0;
            string comb;
            switch(op)
            {
                case 1: precio = 28.5;
                comb="Regular";
                break;
                case 2: precio = 32.00;
                comb="Premium";
                break;
                case 3: precio = 26.75;
                comb="Diesel";
                break;
            }
            int carg=0;
            while(carg<litros)
            {
                carg+=5;
                Console.WriteLine($"\nLitros cargados 5/s: {carg}");
                if(carg+5>litros)
                {
                    Console.WriteLine($"\nLitros cargados {litros-carg}/s");
                    carg = carg+(litros-carg);
                }
            }
            double subtotal=litros*precio;
            double descuento;
            string desc;
            if(subtotal>=1500)
            {
                descuento=0.05;
                desc="5%";
            }
            else if(subtotal>=1000)
            {
                descuento=0.03;
                desc="3%";
            }
            else
            {
              descuento=0;
                desc="0%";   
            }
            double total = subtotal-(subtotal*descuento);
            Console.WriteLine($"Litrs: {litros}");
            Console.WriteLine($"Subtotal: {subtotal:F2}");
            Console.WriteLine($"Descuento: {desc}");
            Console.WriteLine($"TOTAL: {total:F2}");
        }
    }
}