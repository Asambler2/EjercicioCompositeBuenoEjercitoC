using EjercicioFactoriaEjercitoC.Unidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaUnidades
{
    public class FactoriaUnidad : IFactoriaUnidad
    {
        public IMilitarizable DameUnidad()
        {
            string NombreUnidad = "";
            int Velocidad = 0;
            int Blindaje = 0;
            int PotenciaFuego = 0;
            float Precio = 0;
            Console.WriteLine("Escribe el nombre de la unidad");
            NombreUnidad = Console.ReadLine();
            Console.WriteLine("Escribe la velocidad de la unidad");
            Velocidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el blindaje de la unidad");
            Blindaje = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la potencia de fuego de la unidad");
            PotenciaFuego = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el precio de la unidad");
            Precio = float.Parse(Console.ReadLine());
            return new Unidad(NombreUnidad, Velocidad, Blindaje, PotenciaFuego, Precio);
        }
    }
}
