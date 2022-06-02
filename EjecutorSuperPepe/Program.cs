using System;
using LibreriaCompiladorPepe;

namespace EjecutorSuperPepe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pepematic maquina = new Pepematic(args[0]);
            maquina.Ejecutar();
        }
    }
}
