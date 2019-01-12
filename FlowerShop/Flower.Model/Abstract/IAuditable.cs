using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        String CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdatedBy { set; get; }
    }
}
