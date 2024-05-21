using EjercicioFactoriaEjercitoC.ValidadorPresupuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.Ejercito
{
    public interface Ipresupuesto
    {
        public float Presupuesto { get; set; }
        public IValidadorPresupuesto Validador{ get; set; }
    }
}
