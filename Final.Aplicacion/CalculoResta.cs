using Final.Core;

namespace Final.Aplicacion
{
    public class CalculoResta : ICalculo
    {
        public int Calcular(Datos datos)
        {
            return datos.Numero1 - datos.Numero2;
        }
    }
}