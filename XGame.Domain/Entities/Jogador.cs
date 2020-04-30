using prmToolkit.NotificationPattern;
using XGame.Domain.Enum;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador()
        {

        }
        //contrutor para autenticação de jogador
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNotEmail(x => x.Email.EnderecoEmail, "Informe um e-mail válido")
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve ter entre 6 à 32 caracteres");
        }

        public System.Guid Id { get; set; }

        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; set; }

        public EnumSituacaoJogador Status { get; set; }
    }
}
