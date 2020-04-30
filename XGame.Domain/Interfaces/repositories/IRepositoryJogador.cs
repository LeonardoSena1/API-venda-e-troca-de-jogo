using System;
using XGame.Domain.Arguments.Jogador;

namespace XGame.Domain.Interfaces.repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        Guid AdicionarJogador(AdicionarJogadorRequest Request); 

    }
}
