using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.DAL.Repositorios.Contrato
{
    public interface IGenericRepository<TModel> where TModel : class
    {
        //obtener rol, usuario, categoria, etc. Por eso el filtro, para aclarar que queremos obtener
        Task<TModel> Obtener(Expression<Func<TModel, bool>> filtro);

        Task<TModel> Crear(TModel model);

        Task<bool> Editar(TModel model);

        Task<bool> Eliminar(TModel model);

        //select a toda una tabla, por eso filtro x defecto es null
        Task<IQueryable<TModel>> Consultar(Expression<Func<TModel, bool>> filtro = null);

    }
}
