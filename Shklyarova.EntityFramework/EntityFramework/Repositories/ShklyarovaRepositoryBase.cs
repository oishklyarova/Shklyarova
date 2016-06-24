using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Shklyarova.EntityFramework.Repositories
{
    public abstract class ShklyarovaRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ShklyarovaDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ShklyarovaRepositoryBase(IDbContextProvider<ShklyarovaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ShklyarovaRepositoryBase<TEntity> : ShklyarovaRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ShklyarovaRepositoryBase(IDbContextProvider<ShklyarovaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
