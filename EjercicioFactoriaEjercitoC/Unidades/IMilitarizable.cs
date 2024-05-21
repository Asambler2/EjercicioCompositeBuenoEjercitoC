using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.Unidades
{
    public interface IMilitarizable
    {
        public string Titulo { get; set; }
        public int Velocidad {  get; set; }
        public int Blindaje { get; set; }
        public int PotenciaFuego { get; set; }
        public string Mostrar();
    }
}
