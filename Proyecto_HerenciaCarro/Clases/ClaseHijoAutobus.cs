using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HerenciaCarro.Clases
{
    internal class ClaseHijoAutobus : ClasePadreCarro
    {
        public int CapacidadPasajeros { get; }
        public string TipodeRuta { get; set; }
        public ClaseHijoAutobus(string _marca, int _modelo, string _color, int _MAXVEL, int _CapPasajeros, String _TipodeRuta) : base(_marca, _modelo, _color, _MAXVEL)
        {
            CapacidadPasajeros = _CapPasajeros;
            TipodeRuta = _TipodeRuta;
        }
        public string Paradasuben()
        {
            Console.WriteLine("Estan subiendo, suben suben");
            return "";
        }

        public string paradabajan()
        {
            Console.WriteLine("Espera bajan pasajeros, servidos");
            return "";
        }

        public string DameinformacionBus()
        {
            return $" Marca del auto {Marca}  Modelo del auto{Modelo}  Color del auto: {Color} Capacidad de ocupantes: {CapacidadPasajeros} Ruta: {TipodeRuta}";
        }

        }
    }
