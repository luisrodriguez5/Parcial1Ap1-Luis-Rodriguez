using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial_Apl1_Luis_Rodriguez.DAL
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {

        TEntity Guardar(TEntity entity);
        TEntity Buscar(Expression<Func<TEntity, bool>> expresion);
        bool Modificar(TEntity entity);
        bool Eliminar(TEntity entity);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> expression);
        List<TEntity> GetListAll();
    }
}
