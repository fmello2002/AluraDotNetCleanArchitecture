using ScheduleAPI.Application.DTOs.Response;
using ScheduleAPI.Application.Repositories;

namespace ScheduleAPI.Application.UseCases
{
    public class BuscarUsuarios(IUsuarioRepository repository)
    {
        public async Task<IEnumerable<UsuarioOutput>> Execute(Guid? id)
        {
            var usuarios = await repository.BuscarUsuarios(id);
            return usuarios.Select(u => new UsuarioOutput(u.Id, u.Nome, u.Telefone, u.Email.Value, u.CPF.Value));
        }
    }
}