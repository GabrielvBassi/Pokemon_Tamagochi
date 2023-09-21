using Pokemon_Tamagochi;
using RestSharp;

Console.WriteLine("Procurando Pokemon! \n");

Console.WriteLine("Digite o Pokemon que deseja escolher: \n");
Console.WriteLine("1 - Squirtle");
Console.WriteLine("2 - Charmander");
Console.WriteLine("3 - Bulbasaur");
Console.WriteLine("0 - Finalzar programa! \n");

var opcaoPokemon = Console.ReadLine();
var resultado = "";
switch (opcaoPokemon)
{
    case "1":
        resultado = ConsultaPokemon.ConsultarPokemon("squirtle");
        break;
    case "2":
        resultado = ConsultaPokemon.ConsultarPokemon("charmander");
        break;
    case "3":
        resultado = ConsultaPokemon.ConsultarPokemon("bulbasaur");
        break;
    default:
        break;
}

Console.WriteLine(resultado);


Console.WriteLine("Programa finalizado, busca concluída! \n");



public class Pokemon
{
    public string count { get; set; }

    public string next { get; set; }

    public string previous { get; set; }

    public string results { get; set; }
}