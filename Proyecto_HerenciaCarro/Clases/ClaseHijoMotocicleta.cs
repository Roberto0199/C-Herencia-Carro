using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HerenciaCarro.Clases
{
    internal class ClaseHijoMotocicleta : ClasePadreCarro
    {
        public string ClaseDmoto { get; set; }
        public int fuerzaDmotor { get; }
        public ClaseHijoMotocicleta(string _marca, int _modelo, string _color, int _MAXVEL, string _Clsmoto, int _Fmotor) : base(_marca, _modelo, _color, _MAXVEL)
        {
            ClaseDmoto = _Clsmoto;
            fuerzaDmotor = _Fmotor;
        }

        public string Caballito()
        {
            Console.WriteLine("Waoooo que impresionante Caballito");
            return "";
        }

        public string Derrapar()
        {
            Console.WriteLine(" Impresionante pero ten cuidado al derrapar asi");
            return "";
        }
        public string DameinformacionMoto()
        {
            return $" MARCA DEL CARRO: {Marca}  MODELO DEL CARRO: {Modelo}  COLOR DEL CARRO: {Color} CLASE DE MOTO: {ClaseDmoto}  FUERZA DE MOTOR: {fuerzaDmotor}";

        }
    }
    }

