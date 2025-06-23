using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confiteria.Dominio.Modelo.Abstracciones;

namespace Confiteria.Infraestructura.AccesoDatos.Repositorio
{
    public class ClientesRepositorioImpl : RepositorioImpl<Clientes>, IClientesRepositorio
    {
        public ClientesRepositorioImpl(DS_T1DulceFacilContext dBContext) : base(dBContext)
        {
        }
    }
}
