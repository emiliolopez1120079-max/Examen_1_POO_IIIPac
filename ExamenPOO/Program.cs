using ExamenPOO.Ejercicios;

int op;
Ejericcio1_Cotizador_de_envios ejericcio1= new Ejericcio1_Cotizador_de_envios();
Ejercicio2 ejercicio2 = new Ejercicio2();
Ejercicic3 ejercicic3 = new Ejercicic3();
Ejericicio4 ejericicio4 = new Ejericicio4();
Console.WriteLine("ingrese el ejercicio que desea ejecutar\n1. Ejericio1\n2. ejercicio2\n3. Ejericico3\n4. Ejericico4");
int.TryParse(Console.ReadLine(), out op);
if(op==1)
{
    ejericcio1.Cotizador();
}
else if(op==2)
{
    ejercicio2.Combustible();
}
else if(op==3)
{
    ejercicic3.Asistencia();
}
else if (op==4)
{
    ejericicio4.Fila();
}


