using ScheduleAPI.Domain.Entities;

namespace ScheduleAPI.Application.Repositories
{
    public interface IUsuarioRepository
    {
        public Task CadastrarUsuario(Usuario usuario);

        public Task<IEnumerable<Usuario>> BuscarUsuarios(Guid? id);
    }
}