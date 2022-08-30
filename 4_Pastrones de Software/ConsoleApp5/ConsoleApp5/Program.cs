// See https://aka.ms/new-console-template for more information

using ConsoleApp5.Entidades;
using ConsoleApp5.Fabricas;

IFabrica fabrica = new Fabrica();

fabrica.BuildCamisa(1, "Dp", "entallado");
fabrica.BuildPantalon(2, "Dd", "algodon");

//Casteo
var camisa = (Camisa)fabrica.BuildCamisa(3, "Dp", "corto");

