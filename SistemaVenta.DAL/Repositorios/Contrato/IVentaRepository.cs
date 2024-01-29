using SistemaVenta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.DAL.Repositorios.Contrato
{
    //heredamos de interface general, usamos modelo especifico Venta
    public interface IVentaRepository: IGenericRepository<Venta>
    {
        Task<Venta> Registrar(Venta modelo);
    }
}
