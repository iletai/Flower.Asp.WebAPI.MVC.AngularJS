using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower.Data.Infrastructure
{
    public class DbFactory : Dispoable, IDbFactory
    {
        FlowerDbContext dbContext;
        public FlowerDbContext Init()
        {
            return dbContext ?? (dbContext = new FlowerDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
