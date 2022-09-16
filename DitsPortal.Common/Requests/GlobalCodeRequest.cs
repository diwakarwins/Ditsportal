using System.ComponentModel.DataAnnotations;

namespace DitsPortal.Common.Requests
{
  
    public class GlobalCodeRequest
    {
        /// <summary>
        /// Set GlobalCodeCategory Id
        /// </summary>
        [Required]
        public int GlobalCodeCategoryId { get; set; }
        /// <summary>
        /// Set a CodeName for GlobalCode
        /// </summary>
        [Required]
        public string CodeName { get; set; }
        /// <summary>
        /// Give Description for CodeName
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Set Default Active or Deactive
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Logged User Id
        /// </summary>
        public string ActionBy { get; set; }

    }
    public class GlobalCodeCategoryRequest
    {  /// <summary>
       /// Provide a GlobalCodeCategory's CategoryName
       /// </summary>
        [Required]
        public String Name { get; set; }

    }
    public class GlobalCodeUpdateRequest
    {
        /// <summary>
        /// Provide  GlobalCodeId
        /// </summary>
        [Required]
        public int GlobalCodeId { get; set; }
        /// <summary>
        /// Provide GlobalCodeCategoryId 
        /// </summary>
        [Required]
        public int GlobalCodeCategoryId { get; set; }
        //public int ParentGlobalCodeId { get; set; }
        /// <summary>
        ///Provide CodeName
        /// </summary>
        [Required]
        public string CodeName { get; set; }
        /// <summary>
        ///Provide Description 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Set Default Active or Deactive
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Provide Logged User Id
        /// </summary>
        public string ActionBy { get; set; }

    }

    public class GlobalCodeDeleteRequest
    {/// <summary>
     /// Provide GlobalCodeId Id
     /// </summary>
        [Required]
        public int GlobalCodeId { get; set; }
        /// <summary>
        /// Provide Logged User Id
        /// </summary>
        public string ActionBy { get; set; }

    }

    public class GlobalCodeUpdateActiveStatusRequest
    {
        /// <summary>
        /// Provide GlobalCodeId Id
        /// </summary>
        [Required]
        public int GlobalCodeId { get; set; }
        /// <summary>
        /// Set Default Active or Deactive
        /// </summary>
        [Required]
        public bool Active { get; set; }
        /// <summary>
        /// Provide Logged User Id
        /// </summary>
        public string ActionBy { get; set; }

    }

    public class GetGlobalCodeRequest : FilterRequest
    {
        //public int? GlobalCodeCategoryId { get; set; }
        //public string CategoryName { get; set; }
    }
    public class FilterRequest
    {   /// <summary>
        /// Provide a Int value To start Recored From
        /// </summary>
        public int? Page { get; set; } = 1;
        /// <summary>
        /// Provide a Int value To start Recored To
        /// </summary>
        public int? Limit { get; set; } = 10;
        /// <summary>
        /// Need to be like UserId,CreatedOn etc
        /// </summary>
        public string OrderBy { get; set; } = "CreatedOn";
        /// <summary>
        /// Get Descending byTrue And Asending By False
        /// </summary>
        public bool OrderByDescending { get; set; } = true;
        /// <summary>
        /// Provide True And False Value To Get All Recored  
        /// </summary>
        public bool AllRecords { get; set; } = false;
        /// <summary>
        /// Search By Fields like FirstName,LastName,EmailId etc
        /// </summary>
        public string SearchBy { get; set; }
        /// <summary>
        /// Search For Value
        /// </summary>
        public string SearchFor { get; set; }
    }
}