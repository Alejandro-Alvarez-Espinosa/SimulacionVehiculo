using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionVehiculo
{
      public partial class Automovil
    {
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Modelo {  get; set; }
        public string Color { get; set; }
        public double CapacidadTanqueCombustible { get; set; }
        public double NivelCombustible { get; set; }
        public double RendimientoCombustible { get; set; }

        public Automovil(string marca, string placa, string modelo, string color, double capacidadTanqueCombustible, double rendimientoCombustible)
        {
            Marca = marca;
            Placa = placa;
            Modelo = modelo;
            Color = color;
            CapacidadTanqueCombustible = capacidadTanqueCombustible;
            NivelCombustible = 0; 
            RendimientoCombustible = rendimientoCombustible;
        }

    }
}
