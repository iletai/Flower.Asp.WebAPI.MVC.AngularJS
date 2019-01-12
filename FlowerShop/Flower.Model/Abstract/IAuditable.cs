using System;

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