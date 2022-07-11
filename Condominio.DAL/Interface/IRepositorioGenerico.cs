using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DAL.Interface
{
    public  interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> PegarTodos();
        Task<TEntity> PegarPeloId(int id);
        Task<TEntity> PegarPeloId(string id);

        Task Inserir(TEntity entity);
        Task Atulizar(TEntity entity);
        Task Excluir(TEntity entity);
        Task Excluir(int id);
        Task Excluir(string id);


    }
    
}
