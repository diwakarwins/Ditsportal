using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class GlobalCodes:BaseEntity
    {
        
        [Key]
        public int GlobalCodeId { get; set; }

       

        [Column(TypeName = "varchar(250)")]
        public string CodeName { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string Description { get; set; }

         [Column(TypeName = "int")]
         
        [ForeignKey("GlobalCodeCategories")]
        public int GlobalCodeCategoryId { get; set; }
        public GlobalCodeCategories GlobalCodeCategories { get; set; }

        
       
    }
}