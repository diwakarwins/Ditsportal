using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace DitsPortal.Common.Requests
{
    public class GCCategoryRequest
    {
         /// </summary>
        [Required]
        public string CategoryName { get; set; }

        /// <summary>
        /// Give Description For Category Name
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Set Logged User Id
        /// </summary>
        public string ActionBy { get; set; }
        
        /// <summary>
        /// Set Defalut Status For Active And Inactive 
        /// </summary>
        // public bool IsActive { get; set; }
    }
     public class GCCategoryUpdateRequest
    {
        /// <summary>
        /// Provide GlobalCodeCategoryId
        /// </summary>
        [Required]
        public int GlobalCodeCategoryId { get; set; }
        /// <summary>
        /// Provide Global CategoryName
        /// </summary>
        [Required]
        public string CategoryName { get; set; }
        /// <summary>
        /// Give Description For CategoryName
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Set Defalut Status For Active And Inactive 
        /// </summary>
       // public bool IsActive { get; set; }
        /// <summary>
        /// Set Logged User Id
        /// </summary>
        public string ActionBy { get; set; }

    }

    public class GCCategoryDeleteRequest
    {  /// <summary>
       /// Provide GlobalCodeCategoryId
       /// </summary>
        [Required]
        public int GlobalCodeCategoryId { get; set; }
        /// <summary>
        /// Set Logged User Id 
        /// </summary>
        public string ActionBy { get; set; }


    }

    public class GCCategoryUpdateActiveStatusRequest
    {/// <summary>
     /// Provide GlobalCodeCategoryId
     /// </summary>
        [Required]
        public int GlobalCodeCategoryId { get; set; }
        /// <summary>
        /// Set Defalut Status For Active And Inactive 
        /// </summary>
        [Required]
        public bool IsActive { get; set; }
        /// <summary>
        /// Set Logged User Id 
        /// </summary>
        public string ActionBy { get; set; }

    }
}