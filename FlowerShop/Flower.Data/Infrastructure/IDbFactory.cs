using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        FlowerDbContext Init();
    }
}
