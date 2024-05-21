using EjercicioFactoriaEjercitoC.Ejercito;
using EjercicioFactoriaEjercitoC.ValidadorPresupuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaEjercitos
{
    public class FactoriaEjercito : IFactoriaEjercitos
    {
        public IEjercito DameEjercito(IValidadorPresupuesto Validador)
        {
            string NombreEjercito = "";
            float Presupuesto = 0;
            Console.WriteLine("Introduce el nombre del nuevo ejercito.");
            NombreEjercito = Console.ReadLine();
            Console.WriteLine("Introduce el presupuesto del nuevo ejercito.");
            Presupuesto = float.Parse(Console.ReadLine());
            return new EjercitoNuevo(NombreEjercito, Presupuesto, Validador);
        }
    }
}
