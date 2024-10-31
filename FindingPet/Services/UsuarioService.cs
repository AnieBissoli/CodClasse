using FindingPet.Interface;
using FindingPet.Model;

namespace FindingPet.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool ValidarLogin(string email, string senha)
        {
            var usuario = _usuarioRepository.GetUsuarioByEmailSenha(email, senha);
            Console.WriteLine(usuario != null ? "Usuário encontrado" : "Usuário não encontrado");
            return usuario != null;
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            _usuarioRepository.AddUsuario(usuario);
        }

        //public List<Usuario> GetAllUsuarios()
        //{
        //    return _usuarioRepository.GetAllUsuarios();
        //}
    }
}

