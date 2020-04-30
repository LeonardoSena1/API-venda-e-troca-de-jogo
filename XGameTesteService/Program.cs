using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGameTesteService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando");

            var service = new ServiceJogador();
            Console.WriteLine("Criei uma instancia do meu objeto service");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do meu objeto request");
            request.email = "paulo";

            var response = service.AutenticarJogador(request);
            Console.ReadKey();
        }
    }
}
