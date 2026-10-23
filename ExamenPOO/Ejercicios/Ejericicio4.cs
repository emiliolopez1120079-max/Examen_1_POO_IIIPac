namespace ExamenPOO.Ejercicios
{
    public class Ejericicio4
    {
        public void Fila()
        {
            List<string> urgencias = new List<string>();
            List<string> normal = new List<string>();
            int flag=0;
            int op=0;
            while(op!=5)
            {
                Console.WriteLine($"Ingrese el nombre");
                string nombres = Console.ReadLine();
                while(nombres is null)
                {
                    Console.WriteLine($"Ingrese el nombre correctamente");
                    nombres = Console.ReadLine();
                }
                foreach(var u in urgencias)
                {
                    if(u==nombres)
                    {
                        Console.WriteLine("El nombre ya existe en la lista de urgencias");
                        flag=1;
                    }
                }
                foreach(var u in normal)
                {
                    if(u==nombres)
                    {
                        Console.WriteLine("El nombre ya eciste en la lista normal");
                        flag=1;
                    }
                }
                if(flag==0)
                {
                    Console.WriteLine("Ingrese la lista\n1. Urgencias\n2. Normal");
                    while(!int.TryParse(Console.ReadLine(), out op)||op<=0||op>=3)
                    {
                      Console.WriteLine("Numero invalido,intentelo otravez");
                    }
                    if(op==1)
                    {
                        urgencias.Add(nombres);
                    }
                    else
                    {
                        normal.Add(nombres);
                    }
                    if(urgencias.Count>0)
                    {
                        Console.WriteLine($"Paciente {urgencias}  de urgencias atendido");
                        urgencias.RemoveAt(1);
                    }
                    else if(normal.Count>0)
                    {
                        Console.WriteLine("Paciente de normal atendido");
                        normal.RemoveAt(1);
                    }
                    else
                    {
                        Console.WriteLine("No hay pasienctes esperando");
                    }
                    Console.WriteLine("Lista urgencias");
                    foreach(var item in urgencias)
                    {
                        int i=1;
                        Console.WriteLine($"{i}. {item}");
                    }
                    Console.WriteLine("Lista normal");
                    foreach(var item in normal)
                    {
                        int i=1;
                        Console.WriteLine($"{i}. {item}");
                    }
                    Console.WriteLine($"Da un total de: {normal.Count+urgencias.Count}");
                }
              Console.WriteLine("Introdusca 5 si desea salir");
              int.TryParse(Console.ReadLine(), out op);
            }
        }
    }
}