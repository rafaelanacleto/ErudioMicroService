using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.Product.API.Model.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("id")]
        public virtual int Id { get; protected set; }
    }
}
