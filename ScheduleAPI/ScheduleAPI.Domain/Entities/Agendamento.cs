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
                throw new ArgumentException("O horário do agendamento deve ser no futuro.", nameof(horario));

            if (usuarioId == Guid.Empty)
                throw new ArgumentException("Usuário é obrigatório.", nameof(usuarioId));

            Id = Guid.NewGuid();
            Horario = horario;
            Observacao = observacao ?? string.Empty;
            UsuarioId = usuarioId;
        }
    }
}