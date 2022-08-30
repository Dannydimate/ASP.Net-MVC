using ConsoleApp3.Entidades;

//Polimorfismo y casteo (atributo)
Vehiculo vehiculodiesel = new VehiculoDiesel(id: "1", placa: "HGO253", cantidadCetano: 45.2);
var vdiesel = (VehiculoDiesel)vehiculodiesel;
Console.WriteLine(vdiesel.CantidadCetano);

Vehiculo vehiculoelectrico = new VehiculoElectrico(id: "2", placa: "JHG253", horasCarga: 85.3);
var velectrico = (VehiculoElectrico)vehiculoelectrico;
Console.WriteLine(velectrico.HorasCarga);

Vehiculo vehiculogasolina = new VehiculoGasolina(id: "3", placa: "JFR478", sistemaAlimentacion: "gasolina");
var vgasolina = (VehiculoGasolina)vehiculogasolina;
Console.WriteLine(vgasolina.SistemaAlimentacion);


