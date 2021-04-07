using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace project_v2.Models
{
    [Table("Store")]
    public class Store
    {
        [Key]
        public int StoreID {get;set;}
        public string NameStore {get;set;}
        public string Address {get;set;}
        public int amount {get;set;}
        public string Manager{get;set;}
        
        [ForeignKey("StoreID")]
        public ICollection<Product> Products {get;set;}
    }
}