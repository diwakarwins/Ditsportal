namespace DitsPortal.Common.Responses
{


    public class GlobalCodeMainResponse
    {
        public List<GlobalCodeResponse> globalCodeResponse { get; set; }
        public int totalRecords { get; set; }
        public double balance { get; set; }

    }
    public class GlobalCodeResponse
    {
        public int GlobalCodeCategoryId { get; set; }
        public int GlobalCodeId { get; set; }
        public string CodeName { get; set; }
        public string CategoryName { get; set; }
        //public string GlobalCodeCategory { get; set; }
        public string Description { get; set; }
        //public int? ParentGlobalCodeId { get; set; }
        //public string ParentGlobalCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }


    }

}
