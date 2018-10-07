using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Moon.FrameWork.EntityFramework.Repositories
{
    public abstract class FrameWorkRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<FrameWorkDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected FrameWorkRepositoryBase(IDbContextProvider<FrameWorkDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class FrameWorkRepositoryBase<TEntity> : FrameWorkRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected FrameWorkRepositoryBase(IDbContextProvider<FrameWorkDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
