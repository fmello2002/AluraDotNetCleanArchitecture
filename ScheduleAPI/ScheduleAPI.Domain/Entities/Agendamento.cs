using ScheduleAPI.Domain.Exceptions;

namespace ScheduleAPI.Domain.Entities
{
    public class Agendamento
    {
        public Guid Id { get; }
        public DateTime Horario { get; }
        public string Observacao { get; } = string.Empty;

        public Guid UsuarioId { get; }

        public Usuario Usuario { get; } = null!;

        private Agendamento()
        { }

        public Agendamento(DateTime horario, string observacao, Guid usuarioId)
        {
            if (horario <= DateTime.Now)
                throw new DomainException($"O horário do agendamento deve ser no futuro.");

            if (usuarioId == Guid.Empty)
                throw new DomainException($"Usuário é obrigatório.");

            Id = Guid.NewGuid();
            Horario = horario;
            Observacao = observacao ?? string.Empty;
            UsuarioId = usuarioId;
        }
    }
}