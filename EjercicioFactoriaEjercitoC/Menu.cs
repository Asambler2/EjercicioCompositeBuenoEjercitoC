using EjercicioFactoriaEjercitoC.Ejercito;
using EjercicioFactoriaEjercitoC.Unidades;
using EjercicioFactoriaEjercitoC.ValidadorNombreEjercito;
using EjercicioFactoriaEjercitoC.FabricaEjercitos;
using EjercicioFactoriaEjercitoC.FabricaUnidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioFactoriaEjercitoC.ValidadorPresupuesto;

namespace EjercicioFactoriaEjercitoC
{
    public class Menu
    {
        IFactoriaEjercitos FactoriaGrupo = new FactoriaEjercito();
        IMilitarizable GrupoEjercitos;

        public void GenerarGrupo()
        {
            this.GrupoEjercitos = FactoriaGrupo.DameEjercito(new ValidadorDelPresupuesto()) as IMilitarizable;
            GenerarMenu();
        }
        public void GenerarMenu()
        {
            
            int Comando = 0;
            Comando = OpcionesGrupoEjercitos();
            switch(Comando)
            {
                case 1: IFactoriaEjercitos Factoria = new FactoriaEjercito();
                    (GrupoEjercitos as IEjercito).AddUnidad(Factoria.DameEjercito(new ValidadorDelPresupuesto()) as IMilitarizable);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine((GrupoEjercitos as IEjercito).MostrarUnidadesEjercito());
                    Console.ForegroundColor = ConsoleColor.White;
                    break;  
                case 3: IEjercito Ejercito = BuscarEjercito();
                    if(Ejercito != null)MenuEjercito(Ejercito);
                    break;
            }
            if (Comando != 0) GenerarMenu();
        }

        public int OpcionesGrupoEjercitos()
        {
            Console.WriteLine("Pulsa 0 para salir.");
            Console.WriteLine("Pulsa 1 para generar un nuevo ejercito.");
            if ((this.GrupoEjercitos as IEjercito).EjercitoListaUnidades.Count != 0)Console.WriteLine("Pulsa 2 para mostrar Ejercitos.");
            if ((this.GrupoEjercitos as IEjercito).EjercitoListaUnidades.Count != 0) Console.WriteLine("Pulsa 3 para buscar un ejercito existente.");
            return int.Parse(Console.ReadLine());
        }

        public IEjercito BuscarEjercito()
        {
            string ColeccionNombres = "";
            Console.WriteLine("Introduce el nombre del ejercito a buscar");
            string NombreEjercito = Console.ReadLine();
            foreach(IMilitarizable Ejercito in (GrupoEjercitos as IEjercito).EjercitoListaUnidades)
            {
                ColeccionNombres += $"\n{Ejercito.Titulo}";
                if(Ejercito.Titulo.Equals(NombreEjercito))return (Ejercito as IEjercito);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Introduce un nombre de ejercito existente de entre estos nombres. \n{ColeccionNombres}");
            Console.ForegroundColor = ConsoleColor.White;
            return null;
        }

        public int OpcionesEjercito(IEjercito Ejercito)
        {
            int Comando = 0;
            Console.WriteLine("Introduce 1 para añadir una nueva unidad al ejercito.");
            Console.WriteLine("Introduce 2 para mostar información del ejercito.");
            if (Ejercito.EjercitoListaUnidades.Count != 0) {
                Console.WriteLine("Introduce 3 para mostrar todas las unidades del ejercito.");
            }
            Console.WriteLine("Introduce 0 ir al menu de ejercito.");
            Comando = int.Parse(Console.ReadLine());
            return Comando;
        }

        public void MenuEjercito(IEjercito Ejercito)
        {
            int Comando = 0;
            Comando = OpcionesEjercito(Ejercito);
            switch (Comando) {
                case 1: IFactoriaUnidad Factoria = new FactoriaUnidad();
                    Ejercito.AddUnidad(Factoria.DameUnidad());
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine((Ejercito as IMilitarizable).Mostrar());
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3: Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Ejercito.MostrarUnidadesEjercito());
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            if (Comando != 0) MenuEjercito(Ejercito);
        }
    }
}
