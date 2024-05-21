using EjercicioFactoriaEjercitoC.Unidades;
using EjercicioFactoriaEjercitoC.ValidadorPresupuesto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.Ejercito
{
    public class EjercitoNuevo : IEjercito, Ipresupuesto, IMilitarizable
    {
        public int NumElementos { get; set; }
        public float GastoTotal { get; set; } = 0;
        public double CapacidadMilitar { get; set; } = 0;
        public float Presupuesto { get; set; }
        public IValidadorPresupuesto Validador { get; set; }
        public List<IMilitarizable> EjercitoListaUnidades { get; set; } = new List<IMilitarizable>();
        public string Titulo { get; set; }
        public int Velocidad { get; set; } = 0;
        public int Blindaje { get; set; } = 0;
        public int PotenciaFuego { get; set; } = 0;

        public EjercitoNuevo(string NombreEjercito, float Presupuesto, IValidadorPresupuesto Validador )
        {
            this.Titulo = NombreEjercito;
            this.Presupuesto = Presupuesto;
            this.Validador = Validador;
        }

        public void AddUnidad(IMilitarizable Unidad)
        {
            if(Validador.ValidarAddUnidad(Unidad as IMilitarizable, GastoTotal, Presupuesto))
            {
                EjercitoListaUnidades.Add(Unidad);
                this.NumElementos++;
                this.PotenciaFuego += Unidad.PotenciaFuego;
                this.Blindaje += Unidad.Blindaje;
                this.Velocidad += Unidad.Velocidad;
                if(Unidad is ICosteable)this.GastoTotal += (Unidad as ICosteable).Precio;
                this.CapacidadMilitar = CalculoCapacidadMilitar();
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No hay suficiente presupuesto para esta unidad siendo el presupuesto: {this.Presupuesto}" +
                    $" , el gasto total acumulado hasta entonces: {this.GastoTotal}, siendo el precio: {(Unidad as ICosteable).Precio} " +
                    $" y siendo el deficit del presupuesto de {this.Presupuesto - this.GastoTotal - (Unidad as ICosteable).Precio}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public double CalculoCapacidadMilitar()
        {
            return (((double)this.PotenciaFuego * (double)this.Velocidad) / 2) / (100 - (double)this.Blindaje);
        }

        public string MostrarUnidadesEjercito()
        {
            string Cadena = "";
            foreach (IMilitarizable Unidad in EjercitoListaUnidades)
            {
                Cadena += Unidad.Mostrar();
            }
            return Cadena;
        }

        public string Mostrar()
        {
            return $"Nombre Ejercito: {this.Titulo}, Número de elementos: {this.NumElementos}, Potencia total: {this.PotenciaFuego}, " +
                $"Blindaje total {this.Blindaje}, Velocidad total: {this.Velocidad}, Gasto total: {this.GastoTotal}, Capacidad militar: {Math.Round(this.CapacidadMilitar, 2)}, " +
                $"Presupuesto: {this.Presupuesto}, Presupuesto disponible: {this.Presupuesto - this.GastoTotal}";
        }
    }
}
