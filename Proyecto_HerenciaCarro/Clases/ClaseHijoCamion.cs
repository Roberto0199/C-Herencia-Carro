using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HerenciaCarro.Clases
{
    internal class ClaseHijoCamion : ClasePadreCarro
    {
        public int EspacioCarga { get;  }
        public int FuerzaHidraulica { get; }
        public ClaseHijoCamion(string _marca, int _modelo, string _color, int _MAXVEL, int _EspacioCarga, int _FuerzaHidraulica) : base(_marca, _modelo, _color, _MAXVEL)

        {
            EspacioCarga = _EspacioCarga;
            FuerzaHidraulica = _FuerzaHidraulica;

        }
        
        public string LevantarVolteoHidraulico()
        {
            Console.WriteLine( "El sistema hidraulico esta levantado");
            return "";
        } 

        public string DameinformacionCVolteo()
        {
            return $" Marca del Camion: {Marca}  Modelo del camion: {Modelo}  Color del carro: {Color} ESPACIO DE CARGA: {EspacioCarga} FUERZA HIDRAULICA: {FuerzaHidraulica}";

        }

    }
}
