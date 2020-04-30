namespace XGame.Domain.ValueObjects
{
    public class Email
    {
        public Email(string enderecoEmail)
        {
            EnderecoEmail = enderecoEmail;
        }

        public string EnderecoEmail { get; private set; }       
    }
}
