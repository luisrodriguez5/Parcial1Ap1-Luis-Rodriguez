using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial_Apl1_Luis_Rodriguez.DAL
{
    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {

        PrimerParcialDb Context = null;

        public Repositorio()
        {
            Context = new PrimerParcialDb();
        }

        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Context.Set<TEntity>();
            }
        }


        public TEntity Buscar(Expression<Func<TEntity, bool>> expresion)
        {
            try
            {
                return EntitySet.FirstOrDefault(expresion);
            }
            catch { }

            return null;
        }

        public bool Eliminar(TEntity entity)
        {
            try
            {
                EntitySet.Attach(entity);
                EntitySet.Remove(entity);
                return Context.SaveChanges() > 0;
            }
            catch { }

            return false;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> expression)
        {
            try
            {
                return EntitySet.Where(expression).ToList();
            }
            catch { }

            return null;
        }
        public List<TEntity> GetListAll()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch { }

            return null;
        }
        public TEntity Guardar(TEntity entity)
        {
            try
            {

                EntitySet.Add(entity);
                Context.SaveChanges();
                return entity;

            }
            catch { }
            return null;
        }

        public bool Modificar(TEntity entity)
        {
            try
            {
                EntitySet.Attach(entity);

                Context.Entry<TEntity>(entity).State = EntityState.Modified;

                return Context.SaveChanges() > 0;
            }
            catch { }
            return false;
        }
        public void Dispose()
        {
            if (Context != null) Context.Dispose();
        }
    }
}
