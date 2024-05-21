using EjercicioFactoriaEjercitoC.Unidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaUnidades
{
    public interface IFactoriaUnidad
    {
        public IMilitarizable DameUnidad();
    }
}
