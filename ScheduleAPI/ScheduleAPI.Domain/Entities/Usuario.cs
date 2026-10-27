using ScheduleAPI.Domain.ValueObjects;

namespace ScheduleAPI.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; }
        public string Nome { get; } = string.Empty;
        public string Telefone { get; } = string.Empty;
        public Email Email { get; } = null!;
        public CPF CPF { get; } = null!;

        private Usuario()
        { }

        public Usuario(string nome, string telefone, Email email, CPF cpf)
        {
            Id = Guid.NewGuid();
            Nome = string.IsNullOrWhiteSpace(nome) ? throw new ArgumentException("Nome é obrigatório.", nameof(nome)) : nome.Trim();
            Telefone = string.IsNullOrWhiteSpace(telefone) ? throw new ArgumentException("Telefone é obrigatório.", nameof(telefone)) : telefone;
            Email = email ?? throw new ArgumentNullException(nameof(email));
            CPF = cpf ?? throw new ArgumentNullException(nameof(cpf));
        }
    }
}