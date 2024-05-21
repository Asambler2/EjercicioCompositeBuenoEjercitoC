using EjercicioFactoriaEjercitoC.Ejercito;
using EjercicioFactoriaEjercitoC.ValidadorPresupuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaEjercitos
{
    public interface IFactoriaEjercitos
    {
        public IEjercito DameEjercito(IValidadorPresupuesto Validador);
    }
}
