using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public abstract class BaseEntity
    {
        public bool IsActive { get; set; } = true;
        [Column(TypeName = "varchar(50)")]
        public string CreatedBy { get; set; }

        [DefaultValue("GETDATE()")]
        [Column(TypeName = "Datetime")]
        public DateTime? CreatedOn { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(50)")]
        public string? ModifiedBy { get; set; }=null;

        [Column(TypeName = "Datetime")]
        public DateTime? ModifiedOn { get; set; }=null;

        [Column(TypeName = "varchar(50)")]
        public string? DeletedBy { get; set; }=null;

        [Column(TypeName = "Datetime")]
        public DateTime? DeletedOn { get; set; }=null;

        [DefaultValue("0")]
        public bool IsDeleted { get; set; }

        
    
    }
}