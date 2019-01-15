using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private FlowerDbContext dbContext;
        private readonly IDbFactory dbFactory;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public FlowerDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); } 
        }
        public void Commit()
        {
                
        }
    }
}
