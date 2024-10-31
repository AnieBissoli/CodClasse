using FindingPet.Model;

namespace FindingPet.Interface
{
    public interface IUsuarioRepository
    {
        Usuario GetUsuarioByEmailSenha(string email, string senha);
        void AddUsuario(Usuario usuario);
        //List<Usuario> GetAllUsuarios();
    }
}
