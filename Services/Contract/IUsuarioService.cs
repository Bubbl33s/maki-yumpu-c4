using Microsoft.EntityFrameworkCore;
using MakiYumpuWorkers.Models;

namespace MakiYumpuWorkers.Services.Contract
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuario(string login, string password);
        Task<Usuario> CreateUsuario(Usuario modelo);
    }
}
