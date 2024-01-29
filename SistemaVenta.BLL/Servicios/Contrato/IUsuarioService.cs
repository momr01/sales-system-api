using SistemaVenta.DTO;

namespace SistemaVenta.BLL.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<List<UsuarioDTO>> Lista();
        
        //devuelve SesionDTO
        Task<SesionDTO> ValidarCredenciales(string correo, string clave);

        //devuelve usuarioDTO
        Task<UsuarioDTO> Crear(UsuarioDTO modelo);

        Task<bool> Editar(UsuarioDTO modelo);

        Task<bool> Eliminar(int id);
    }
}
