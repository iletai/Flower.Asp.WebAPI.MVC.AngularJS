using System;
using System.ComponentModel.DataAnnotations;

namespace Flower.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreateDate { set; get; }

        [MaxLength(256)]
        public string CreateBy { set; get; }

        public DateTime? UpdateDate { set; get; }
        public string UpdatedBy { set; get; }
    }
}