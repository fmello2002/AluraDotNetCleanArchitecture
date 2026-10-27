using Microsoft.EntityFrameworkCore;
using ScheduleAPI.Application.Repositories;
using ScheduleAPI.Domain.Entities;

namespace ScheduleAPI.Infrastructure.Persistence.Repositories
{
    public class UsuarioRepository(ScheduleDbContext context) : IUsuarioRepository
    {
        public async Task<IEnumerable<Usuario>> BuscarUsuarios(Guid? id)
        {
            IEnumerable<Usuario> usuarios;

            if (id is null)
            {
                usuarios = await context.Usuarios.AsNoTracking().ToListAsync();
                return usuarios;
            }

            usuarios = await context.Usuarios.AsNoTracking().Where(u => u.Id == id).ToListAsync();

            return usuarios;
        }

        public async Task CadastrarUsuario(Usuario usuario)
        {
            await context.Usuarios.AddAsync(usuario);
            await context.SaveChangesAsync();
        }
    }
}