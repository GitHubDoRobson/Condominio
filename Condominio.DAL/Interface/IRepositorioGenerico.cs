﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DAL.Interface
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> PegarTodos();

        Task<TEntity> PegarPeloId (string id);
        Task<TEntity> PegarPeloId (int id);

        Task Inserir (TEntity entity);
        Task Atualizar (TEntity entity);
        Task Excluir (TEntity entity);
        Task Excluir (string id);
        Task Excluir (int id);
    }
}
