using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.Unidades
{
    public class Unidad : IMilitarizable, ICosteable
    {
        public string Titulo { get; set; }
        public int Velocidad { get; set; }
        public int Blindaje { get; set; }
        public int PotenciaFuego { get; set; }
        public float Precio { get; set; }

        public Unidad (string titulo, int velocidad, int blindaje, int potenciaFuego, float precio)
        {
            Titulo = titulo;
            Velocidad = velocidad;
            Blindaje = blindaje;
            PotenciaFuego = potenciaFuego;
            Precio = precio;
        }

        public string Mostrar()
        {
            return $"Unidad: {this.Titulo} con velocidad: {this.Velocidad}, blindaje: {this.Blindaje}, potencia de fuego: {this.PotenciaFuego} y precio: {this.Precio}";
        }
    }
}
