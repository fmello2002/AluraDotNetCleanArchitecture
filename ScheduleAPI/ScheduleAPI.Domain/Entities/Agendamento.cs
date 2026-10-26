namespace ScheduleAPI.Domain.Entities
{
    public class Agendamento(Guid id, DateTime horario, string observacao, Usuario usuario)
    {
        public Guid Id { get; } = id;
        public DateTime Horario { get; } = horario;
        public string Observacao { get; } = observacao;
        public Usuario Usuario { get; } = usuario;
    }
}