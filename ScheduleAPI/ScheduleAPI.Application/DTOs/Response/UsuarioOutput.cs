namespace ScheduleAPI.Application.DTOs.Response
{
    public record UsuarioOutput(
    Guid id,
    string Nome,
    string Telefone,
    string Email,
    string CPF
);
}