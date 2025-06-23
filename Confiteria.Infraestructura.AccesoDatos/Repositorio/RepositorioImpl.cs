using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confiteria.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;

namespace Confiteria.Infraestructura.AccesoDatos.Repositorio
{
    public class RepositorioImpl<T> : IRepositorio<T> where T : class
    {

        private readonly DS_T1DulceFacilContext _dBContext;

        private readonly DbSet<T> _dbSet;

        public RepositorioImpl(DS_T1DulceFacilContext dBContext) {

            _dBContext = dBContext;
            _dbSet = dBContext.Set<T>();

        }    

        //Metodo insertar
        public async Task AddAsyncs(T entidad)
        {
            try
            {
                await _dbSet.AddAsync(entidad);//Insertar tablas 
                await _dBContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("Error No se pudo insertar los datos" + ex.Message);
            }
        }
        //Metodo Eliminar 
        public async Task DeleteAsynsc(int id)
        {

            try
            {
                //variable
                var entidad = await GetByIdAsync(id);
                _dbSet.Remove(entidad);
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error No se pudo eliminar los datos" + ex.Message);
            }
        }

        //Metodo Listar
        public async Task<IEnumerable<T>> GetAllAsynsc()
        {
            try
            {
                return await _dbSet.ToListAsync();

            }catch (Exception ex) {
                throw new Exception("Error No se pudo listar los datos" + ex.Message);
            }
        }

        //buscar por id
        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error No se pudo recuperae los datos" + ex.Message);
            }
        }
        //Metodo Actaulizar
        public async Task UpdateAsynsc(T entidad)
        {
            try
            {
                _dbSet.Update(entidad);
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error No se pudo actualizar los datos" + ex.Message);
            }
        }
    }
}
