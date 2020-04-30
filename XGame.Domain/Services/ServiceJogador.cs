using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador()
        {
        }

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest Request)
        {
            Jogador jogador = new Jogador();
            jogador.Email = Request.Email;
            jogador.Senha = Request.Senha;
            jogador.Status = Enum.EnumSituacaoJogador.EmAndamento;

            Guid id = _repositoryJogador.AdicionarJogador(jogador);

            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("AutenticarJogadorRequest é obrigatorio");
            }

            var email = new Email("Leonardo");

            var jogador = new Jogador(email, "2311");

            AddNotifications(jogador);

            if (jogador.IsInvalid())
            {
                return null;
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
