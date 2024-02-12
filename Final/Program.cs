using Final.Core;
using Final.Aplicacion;

Datos datos = new Datos();

void ConsultarDatos()
{
    Console.WriteLine("Bienvenid@:");
    Console.WriteLine("Ingrese el numero 1 para realizar una SUMA");
    Console.WriteLine("Ingrese el numero 2 para realizar una RESTA");
    datos.Operacion = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el primer numero de la operacion");
    datos.Numero1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo numero de la operacion");
    datos.Numero2 = Convert.ToInt32(Console.ReadLine());

}

ConsultarDatos();

if (datos.Operacion == 1)
    Calculo(datos, new CalculoSuma());
else
    Calculo(datos, new CalculoResta());


void Calculo(Datos datos, ICalculo calculoFinal)
{
    Console.WriteLine("El resultado de la operacion realizada es: " + calculoFinal.Calcular(datos));
}