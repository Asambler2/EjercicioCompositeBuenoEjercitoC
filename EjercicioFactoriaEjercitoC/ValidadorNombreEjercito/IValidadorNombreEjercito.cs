using EjercicioFactoriaEjercitoC.Ejercito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.ValidadorNombreEjercito
{
    public interface IValidadorNombreEjercito
    {
        public bool ValidaElNombreEjercito(IEjercito Ejercito, List<IEjercito> GrupoEjercitosTotal);
    }
}
