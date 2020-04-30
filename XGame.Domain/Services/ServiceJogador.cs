using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interfaces.repositories;
using XGame.Domain.Interfaces.Services;

namespace XGame.Domain.Services
{
    public class ServiceJogador : IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest Request)
        {
            Guid id = _repositoryJogador.AdicionarJogador(Request);

            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if(request == null)
            {
                throw new Exception("AutenticarJogadorRequest é obrigatorio");
            }

            if (string.IsNullOrEmpty(request.email))
            {
                throw new Exception("Informe um Email");
            }
            
            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Informe uma Senha");
            }

            if (IsEmail(request.email))
            {
                throw new Exception("Informe um Email");
            }

            if (request.Senha.Length < 6)
            {
                throw new Exception("Informe uma semana no minimo de 6 caractere");
            }

            var response = _repositoryJogador.AutenticarJogador(request);

            return response;
        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}
