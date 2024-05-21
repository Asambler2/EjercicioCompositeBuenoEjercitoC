using EjercicioFactoriaEjercitoC.Ejercito;
using EjercicioFactoriaEjercitoC.Unidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.ValidadorNombreEjercito
{
    public class ValidaNombreEjercitocs : IValidadorNombreEjercito
    {
        public bool ValidaElNombreEjercito(IEjercito Ejercito, List<IEjercito> GrupoEjercitosTotal)
        {
            foreach (IMilitarizable ElEjercito in GrupoEjercitosTotal)
            {
                return (ElEjercito.Titulo.Equals((Ejercito as IMilitarizable).Titulo) ? false : true);
            }
            return true;
        }
    }
}
