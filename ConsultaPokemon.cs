using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Pokemon_Tamagochi
{
    public class ConsultaPokemon
    {

            public static string ConsultarPokemon(string nomePokemon)
            {
                var pokemon = nomePokemon;
                var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemon}/");
                RestRequest request = new RestRequest("", Method.Get);
                // execução do método GET

                var response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return response.ErrorMessage;
                }

        }
    }
}
