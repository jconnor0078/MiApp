using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MiApp.EntityFramework.Repositories
{
    public abstract class MiAppRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MiAppDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MiAppRepositoryBase(IDbContextProvider<MiAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MiAppRepositoryBase<TEntity> : MiAppRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MiAppRepositoryBase(IDbContextProvider<MiAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
