using ScheduleAPI.Domain.ValueObjects;

namespace ScheduleAPI.Domain.Entities
{
    public class Usuario(Guid id, string nome, string telefone, Email email, CPF cPF)
    {
        public Guid Id { get; } = id;
        public string Nome { get; } = nome;
        public string Telefone { get; } = telefone;
        public Email Email { get; } = email;
        public CPF CPF { get; } = cPF;
    }
}