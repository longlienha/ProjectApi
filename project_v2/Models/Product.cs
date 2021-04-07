using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_v2.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Brand { get; set; }
        public decimal Price {get;set;}
        public decimal Selling_Price{get;set;}

        public int StoreID {get;set;}
        public Store Store{get;set;}
    }
}
