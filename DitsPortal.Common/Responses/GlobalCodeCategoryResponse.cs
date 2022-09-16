namespace DitsPortal.Common.Responses
{
    
    public class GlobalCodeCategoriesResponse
    {
        public int GlobalCodeCategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string  CreatedBy { get; set; }
        

    }
}