using EjercicioFactoriaEjercitoC.Unidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.ValidadorPresupuesto
{
    public interface IValidadorPresupuesto
    {
        public bool ValidarAddUnidad(IMilitarizable LaUnidad, float GastoTotal, float Presupuesto);
    }
}
