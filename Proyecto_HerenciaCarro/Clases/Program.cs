using Proyecto_HerenciaCarro;
using Proyecto_HerenciaCarro.Clases;


ClaseHijoMotocicleta Moto= new ClaseHijoMotocicleta("Kawasaki", 2021, "Azul", 220, "",140);
string mensaje;

Console.WriteLine("\n");
Console.WriteLine(Moto.DameinformacionMoto());
Console.WriteLine("\n");

Moto.EncenderMotor();
Moto.acelerar();
Moto.acelerar();
Moto.acelerar();
Moto.FrenadoNormal();
Console.WriteLine(Moto.GetVelocidadActual());
Moto.Caballito();
Moto.Claxón();
Moto.acelerar();
Moto.acelerar();
Moto.acelerar();
Moto.Derrapar();
Moto.Frenado_total();
Console.WriteLine(Moto.GetVelocidadActual());










