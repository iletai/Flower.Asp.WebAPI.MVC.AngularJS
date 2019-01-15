using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower.Data.Infrastructure
{
    public class Dispoable : IDisposable
    {
        private bool isDisposed ;
        ~Dispoable()
        {
            Dispose(false);
        };
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
                DisposeCore();

            isDisposed = true;
        }

        //Overwrite  this function to dispose  custom object
        protected virtual void DisposeCore()
        {

        }
    }
}
