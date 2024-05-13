using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionVehiculo
{
    public partial class Automovil
    {
        public bool Conducir(int distancia)
        {
          double CombustibleNecesario = distancia / RendimientoCombustible;

            if( NivelCombustible >= CombustibleNecesario)
            {
                NivelCombustible -= CombustibleNecesario;
                Console.WriteLine($"El vehiculo {Marca} {Modelo} pudo recorrer {distancia} KM");
            }
            else
            {
                Console.WriteLine($"El vehiculo {Marca} {Modelo} no tiene suficiente combustible para viajar {distancia} Km. Se requieren {CombustibleNecesario - NivelCombustible} galones extra");
            }
               return CombustibleNecesario <= NivelCombustible;
        }

        public void ReabastecerCombustible(double cantidad)
        {
            if (cantidad > 0)
            {
                double TanqueMedio = NivelCombustible + cantidad;
                if (TanqueMedio > CapacidadTanqueCombustible)
                {
                    NivelCombustible = CapacidadTanqueCombustible;
                    Console.WriteLine($"Se ha reabastecido {CapacidadTanqueCombustible - NivelCombustible} galones, tanque lleno ");
                }
                else
                {
                    NivelCombustible = TanqueMedio;
                    Console.WriteLine($"Se he reabastecido {cantidad} galones");
                }
            }
            else
            {
                Console.WriteLine("La cantidad para llenar de ser mayor que 0 ");
            }
        }

        public bool PuedeConducir(int distancia)
        {
            double CombustibleNecesario = distancia / RendimientoCombustible;

            if(NivelCombustible >= CombustibleNecesario)
            {
                return true; //Si hay Gasolina para ir a Pochomil
            }
            else
            {
                return false; //No hay Gasolina para ir a Pochomil
            }
        }
    }
}
