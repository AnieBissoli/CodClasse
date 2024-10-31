using FindingPet.Interface;
using FindingPet.Model;

namespace FindingPet.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly List<Usuario> _usuarios = new List<Usuario>
    {
        new Usuario { Nome = "Usuário Teste", Email = "teste@teste.com", Senha = "1234", Cpf = 123456789, Estado = "SP", Endereco = "Rua Teste", NumeroEndereco = 123 }
    };

        public void AddUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public Usuario GetUsuarioByEmailSenha(string email, string senha)
        {
            return _usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
