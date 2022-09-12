using ConsoleApp6.Entitys;
using ConsoleApp6.Recreacion;

//registro

Zoologico<Visitante> zoologico = new Zoologico<Visitante>();
List<Visitante> r = zoologico.Registrar(new Visitante());

Console.WriteLine(r.Count);
