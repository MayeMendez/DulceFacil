using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiteria.Dominio.Modelo.Abstracciones
{
    public interface IRepositorio<T> where T : class
    {
        //Insertar
        Task AddAsyncs (T entidad);

        //Actualizar
        Task UpdateAsynsc(T entidad);

        //Eliminar
        Task DeleteAsynsc(int id);

        //Listar
        Task<IEnumerable<T>> GetAllAsynsc();    

        //Buscar por id
        Task<T> GetByIdAsync(int id);

    }
}
