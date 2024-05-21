using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioFactoriaEjercitoC.Unidades;

namespace EjercicioFactoriaEjercitoC.Ejercito
{
    public interface IEjercito
    {
    public List<IMilitarizable> EjercitoListaUnidades { get; set; }
        public int NumElementos { get; set; }
        public float GastoTotal { get; set; }
        public double CapacidadMilitar { get; set; }

        public void AddUnidad(IMilitarizable unidad);
        public double CalculoCapacidadMilitar();
        public string MostrarUnidadesEjercito();
    }
}
