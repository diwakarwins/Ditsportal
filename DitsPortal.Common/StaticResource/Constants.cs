
namespace DitsPortal.Common.StaticResource
{
    public class Constants
    {
    
        public const int SUCCESS_CODE = 200;
        public const int FAILURE_CODE = 400;
        public const int ERROR_CODE = 500;

        // Common
        public const string DEFAULT_ERROR_MSG = "Something went wrong";
        public const string DEFAULT_SUCCESS_MSG = "Success";
        public const string NO_RECORD_FOUND = "Email does not exist.";
        public const string INVALID_LOGIN = "Invalid User Email Password.";
        public const string LogIn_success = "LogIn Successfully";
        public const string LOGOUT_SUCCESS = "Logout Successfull";
        public const string LOGOUT_FAILURE = "LogOUT Unsuccessfull";
        public const string Data_Found = "Data Found";
        public const string No_Data_Found = "No Data Found";
        public const string INTERNAL_SERVER_ERROR = "Internal Server Error from the custom middleware";

        // User Screen
        public const string USER_NOT_EXITS = "User not exits.";
        public const string USER_WAIT_APPROVAL = "Wait For Approval";
        public const string USER_EXITS = "User Exits";
        public const string USER_PROFILE_CREATED = "User Profile Created Successfully";
        public const string USER_PROFILE_UPDATE = "User Profile Update successfully";
        public const string ACCOUNT_APPROVED_SUCCESS = "User Account Approved successfully";
        public const string ACCOUNT_APPROVAL_REJECT = "User Account Approval Reject";
        public const string USER_APPROVAL_REJECTED = "Your Account Approval Rejected";
        public const string LOGIN_FAILURE_MSG = "Username or password is incorrect";
        public const string EMAIL_ALREADY_EXIST = "Email already exists";
        public const string OLD_PASSWORD_INCORRECT = "Old password incorrect";
        public const string OLD_NEW_PASSWORD_SAME_ERROR = "New password can not be same as old password.";
        public const string PASSWORD_CHANGED = "Password changed successfully.";
        public const string PROFILE_UPDATED = "User Profile updated successfully.";
        public const string USER_REGISTERED = "User registered successfully.Please wait for admin approval";
        public const string RESET_PASSWORD_EMAIL = "Your password reset email has been sent.";
        public const string User_Deleted = "User Deleted Successfully";
        public const string User_Not_Deleted = "User Deleted Failed";

        //Users Registration Screen
        public const string USER_CREATED = "User created successfully.";
        public const string USER_NOT_CREATED = "Please fill the required fields.";
        public const string USER_UPDATED = "User   updated successfully.";
        public const string USER_NOT_UPDATED = "User not updated successfully.";
        public const string USER_NOT_EXISTS = "User not exits.";
        public const string USER_DELETED = "User deleted successfully.";
        public const string USER_NOT_DELETED = "User not deleted successfully.";
        public static readonly string RESET_PASSWORD_VALID_LINK = "Reset password link is valid.";
        public static readonly string RESET_PASSWORD_EXPIRED_LINK = "Reset password link is expired";

        //Leave Screen
        public const string LEAVE_CREATED = "Your leave request has been submitted successfully.";
        public const string LEAVE_CREATED_EMAIL_ERROR = "Your leave request has been submitted successfully, but unable to send an email to admin.";
        public const string LEAVE_NOT_CREATED = "Your leave request has been failed.";
        public const string LEAVE_APPROVED = "Leave approved successfully";
        public const string LEAVE_NOT_APPROVED = "Leave declined successfully";
        public const string NO_LEAVE_AVAILABLE = "No leave available.";
        public const string LEAVE_UPDATE = "Leave updated successfully.";
        public const string LEAVE_NOT_UPDATE = "Leave updated failed";
        public const string ALLREADY_HAVE_LEAVE = "Already Have A Leave With Same Date";
        public const string INVALID_REQUEST = "Invalid Request Parameters";
        public const string NO_LEAVE_RECORD_FOUND = "No Leave Record Found";
        public const string EMPLOYEE_LEAVE_COUNT_FOUND = "Leave Record Found";
        public const string EMPLOYEE_LEAVE_COUNT_NOT_FOUND = "Leave Record Not Found";


        /* Validation Messages */
        public const string VALIDATION_FULLNAME_ERROR_MSG = "Name should contains alphabets, space and dot";
        public const string VALIDATION_PASSWORD_ERROR_MSG = "Password is not strong";
        public const string VALIDATION_PASSWORD_NOT_SAME_MSG = "Confirm password is not same as password.";

        // GlobalCode Category Screen 
        public const string GLOBAL_CODE_CATEGORY_CREATED = "Global Code Category created successfully.";
        public const string GLOBAL_CODE_CATEGORY_NOT_CREATED = "Please fill the required fields.";
        public const string GLOBAL_CODE_CATEGORY_UPDATED = "Global code category updated successfully.";
        public const string GLOBAL_CODE_CATEGORY_NOT_UPDATED = "Global code category not updated successfully.";
        public const string GLOBAL_CODE_CATEGORY_DELETED = "Global code category deleted successfully.";
        public const string GLOBAL_CODE_CATEGORY_NOT_DELETED = "Global Code Cateegory not deleted successfully.";
        public const string GLOBAL_CODE_CATEGORY_NOT_EXISTS = "Global Code Category not exist.";
        public const string GLOBAL_CODE_CATEGORY_AllRECORDS_UPDATED = "GLOBAL_CODE_CATEGORY_AllRECORDS_UPDATED";

        //Email Errors
        public const string EMAIL_ERROR = "Error while sending email";

        //Role Messages
        public const string Role_Created_Success = "Role Created Successfully";
        public const string Role_Save_Success = "Role Save Created";
        public const string Role_Not_Created = "Role Not Created";
        public const string Role_Update_Success = "Role Updated Successfully";
        public const string Role_Not_Update = "Role Not Update";
        public const string Role_Deleted_Success = "Role Deleted Successfully";
        public const string Role_Not_Delete = "Role Not Delete";


        //User Role Messages
        public const string User_Role_Created_Success = "User Role Created Successfully";
        public const string User_Role_Not_Created_Success = "User Role Not Created Successfully";
        public const string User_Role_Updated_Success = "User Role Updated Successfully";
        public const string User_Role_Not_Updated_Success = "User Role Not Updated Successfully";
        public const string User_Role_Deleted_Success = "User Role Deleted Successfully";
        public const string User_Role_Not_Deleted_Success = "User Role Not Deleted Successfully";
        public const string Role_Already_Exists = "Role Already Exists";
        public const string Role_Exist = "Role Exist";
        public const string Role_Not_Exist = "Role Not Exist";
        //Screen Messages
        public const string Screen_Created_Success = "Screen Created Successfully";
        public const string Screen_Already_Exists = "Screen Already Exists";
        public const string Screen_Update_Success = "Screen Updated Successfully";
        public const string Screen_Not_Update = "Screen Not Updated";
        public const string Screen_Deleted_Success = "Screen Deleted Successfully";
        public const string Screen_Not_Delete = "Screen Not Deleted";
        public const string Screen_Exist = "Screen Exist";
        public const string Screen_Not_Exist = "Screen Not Exist";
        // RolePermission Messages
        public const string RolePermission_Not_Update = "Role Permission Not Update";
        public const string RolePermission_Update = "Role Permission Update Successfully";
        public const string RolePermission_Created_Success = "Role Permission Created Successfully";
        public const string RolePermission_Exist = "Role Permission Exist";
        public const string RolePermission_Not_Exist = "Role Permission Not Exist";
        public const string RolePermission_Already_Exists = "Already Have Role Permission";
        public const string RolePermission_Deleted_Success = "Role Permission Delete Successfully";
        public const string RolePermission_Not_Delete = "Role Permission Not Delete";
        //Project Messages
        public const string Project_Available = "Project Available";
        public const string Project_Not_Available = "Project Not Available";
        public const string Project_Add = "Project Added Successfully";
        public const string Project_Not_Add = "Project Added Failed";
        public const string Project_Update = "Project Updated Successfully";
        public const string Project_Not_Update = "Project Updated Failed";
        public const string Project_Deleted = "Project Deleted Successfully";
        public const string Project_Not_Deleted = "Project Deleted Failed";
        public const string Project_Image_Add = "Project Image Added Successfully";
        public const string Project_Image_Not_Add = "Project Image Added Failed";
        public const string Project_Image_Deleted = "Project Image Deleted Successfully";
        public const string Project_Image_Not_Deleted = "Project Image Deleted Failed";
        public const string Project_Image_Not_Valid = "Project Image Not Valid";       
        public const string Project_Activated = "Project Activated Now";       
        public const string Project_Deactivated = "Project Deactivated Now";
        public const string Project_Assign = "Project Assigned Successfully";
        public const string Project_Unassign = "Project Unassigned Successfully";
        public const string Project_Assign_Not = "Did not find any assigned project";
        //Skill Messages
        public const string Skill_Created_Success = "Skill Created Successfully";
        public const string Skill_Already_Exists = "Skill Created And Some Skill Already Exists";
        public const string Skill_Update_Success = "Skill Updated Successfully";
        public const string Skill_Not_Update = "Skill Not Updated";
        public const string Skill_Deleted_Success = "Skill Deleted Successfully";
        public const string Skill_Not_Delete = "Skill Not Deleted";
        public const string Skill_Exist = "Skill Exist";
        public const string Skill_Not_Exist = "Skill Not Exist";
        //Qualification Messages
        //public const string Qualification_Already_Exists = "Qualification Already Exists";
        public const string Qualification_Already_Exists = "Qualification Created And Some Qualification Already Exists";
        public const string Qualification_Created_Success = "Qualification Created Successfully";
        public const string Qualification_Not_Created = "Qualification Not Created";
        public const string Qualification_Not_Update = "Qualification Not Update";
        public const string Qualification_Update_Success = "Qualification Updated Successfully";
        public const string Qualification_Exist = "Qualification Exist";
        public const string Qualification_Not_Exist = "Qualification Not Exist";
        public const string Qualification_Not_Delete = "Qualification Not Deleted";
        public const string Qualification_Delete = "Qualification Deleted Successfully";
        //EmployeeHistory Messages
        public const string EmployeeHistory_Available = "Employee History Available";
        public const string EmployeeHistory_Not_Available = "Employee History Not Available";
        public const string EmployeeHistory_Added = "Employee History Added Successfully";
        public const string EmployeeHistory_Not_Added = "Employee History Added Failed";
        public const string EmployeeHistory_Updated = "Employee History Updated Successfully";
        public const string EmployeeHistory_Not_Update = "Employee History Updated Failed";
        public const string EmployeeHistory_Delete = "Employee History Deleted";
        public const string EmployeeHistory_Not_Delete = "Employee History Deleted Failed";        
        //Client Messages
        public const string Client_Available = "Client  Available";
        public const string Client_Not_Available = "Client  Not Available";
        public const string Client_Add = "Client Added Successfully";
        public const string Client_Not_Add = "Client Added Failed";
        public const string Client_Update = "Client Updated Successfully";
        public const string Client_Not_Update = "Client Updated Failed";
        public const string Client_Delete = "Client Deleted Successfully";
        public const string Client_Not_Delete = "Client Deleted Failed";
        public const string Client_Project_Available = "Client Project Available";
        public const string Client_Project_Not_Available = "Client Project Not Available";
        public const string Client_Project_Add = "Client Project Added Successfully";
        public const string Client_Project_Not_Add = "Client Project Added Failed";
        public const string Client_Project_Update = "Client Project Updated Successfully";
        public const string Client_Project_Not_Update = "Client Project Updated Failed";
        public const string Client_Project_Delete = "Client Project Deleted Successfully";
        public const string Client_Project_Not_Deleted = "Client Project Deleted Failed";

        //Inventory Message
        public const string Inventory_Created_Success = "Inventory Created Successfully";
        public const string Inventory_Not_Created = "Inventory Not Created";
        public const string Inventory_Already_Exists = "Inventory Already Exists";
        public const string Inventory_Update_Success = "Inventory Updated Successfully";
        public const string Inventory_Not_Update = "Inventory Not Updated";
        public const string Inventory_Deleted_Success = "Inventory Deleted Successfully";
        public const string Inventory_Not_Delete = "Inventory Not Deleted";
        public const string Inventory_Exist = "Inventory Exist";
        public const string Inventory_Not_Exist = "Inventory Not Exist";
        //Hardware Message
        public const string Hardware_Available = "Hardware Available";
        public const string Hardware_Not_Available = "Hardware Not Available";
        public const string Hardware_Add = "Hardware Added Successfully";
        public const string Hardware_Not_Add = "Hardware Added Failed";
        public const string Hardware_Update = "Hardware Updated Successfully";
        public const string Hardware_Not_Update = "Hadware Updated Failed";
        public const string Hardware_Delete = "Hardware Deleted Successfully";
        public const string Hardware_Not_Delete = "Hardware Deleted Failed";
        public const string Hardware_Request_Send = "Hardware Request Sent";
        public const string Hardware_Request_Not_Send = "Hardware Request Failed";
        public const string Hardware_Assign = "Hardware Assign Successfully";
        public const string Hardware_Not_Assign = "Hardware Assign Failed";
        public const string Hardware_Unassign = "Hardware Unassign Successfully";
        public const string Hardware_Not_Unassign = "Hardware Unassign Failed";
        // Global Code Screen 
        public const string GLOBAL_CODE_CREATED = "Global Code created successfully.";
        public const string GLOBAL_CODE_NOT_CREATED = "Please fill the required fields.";
        public const string GLOBAL_CODE_UPDATED = "Global code updated successfully.";
        public const string GLOBAL_CODE_NOT_UPDATED = "Global code not updated successfully.";
        public const string GLOBAL_CODE_DELETED = "Global code deleted successfully.";
        public const string GLOBAL_CODE_NOT_DELETED = "Global Code not deleted successfully.";
        public const string GLOBAL_CODE_NOT_EXISTS = "Global Code not exist.";
        public const string GLOBAL_CODE_AllRECORDS_UPDATED = "";

        //Resignation Msg
        public const string RESIGNATION_APPLY_SUCCESSFULLY = "Resignation Applyed Successfully Please Wait For The Revert";
        public const string REVERT_SUCCESS = "Revert Send Successfully";
        public const string REVERT_NOT_SUCCESS = "Revert Not Send";
        public const string RESIGNATION_NOT_APPLYED = "Resignation Not Applyed";
        public const string REVERT_CREATE = "Revert Create Successfully";
        public const string REVERT_NOT_CREATE = "Revert Not Create";
        public const string RESIGNATION_RECORD_NOT_FOUND = "Resignation Record Not Found";
        public const string RESIGNATION_RECORD_FOUND = "Resignation Record Found";
        public const string RESIGNATION_DETAIL = "Resignation Detail Exist";


        //Appraisal Msg
        public const string APPRAISAL_APPLY_UPDATE = "Appraisal Apply Update Successfully";
        public const string APPRAISAL_APPLY = "Appraisal Apply Successfully";
        public const string APPRAISAL_REVERT = "Appraisal Revert Successfully";
        public const string APPRAISAL_REVERT_UNSUCCESSFULLY = "Appraisal Revert UnSuccessfully";
        public const string Error_While_Sending_Mail = "Error While Sending Mail";
        public const string APPRAISAL_Detail = "Appraisal Detail Exist";
        public const string APPRAISAL_Detail_NOT_EXIST = "Appraisal Detail Not Exist";
        public const string APPRAISAL_RECORD_FOUND = "Appraisal Record Found";
        public const string APPRAISAL_RECORD_NOT_FOUND = "Appraisal Record Not Found";
        public const string APPRAISAL_APPROVAL = "APPROVED";
        public const string APPRAISAL_DENY = "DENY";

        //Prospects
        public const string Prospects_Submitted = "Prospects Submitted Successfully";
        public const string Prospects_Updated = "Prospects Updated Successfully";
        public const string Prospects_Not_Found= "Prospects Not Found";
        public const string Prospects_Found= "Prospects  Found";
        public const string Prospects_Deleted= "Prospects Deleted Successfully";
        public const string Prospects_Not_Deleted= "Prospects Deleted Failed";
        //DSR Msg
        public const string DSR_ADD = "DSR Add Successfully";
        public const string DSR_NOT_ADD = "DSR Not Added";
        public const string DSR_UPDATE = "DSR Update Successfully";
        public const string DSR_NOT_UPDATE = "DSR Not Update Successfully";
        public const string DSR_DELETED = "DSR Data Delete Successfully";
        public const string DSR_NOT_DELETED = "DSR Data Not Delete";
        public const string DSR_RECORD_FOUND = "DSR Recored Found Successfully";
        public const string DSR_RECORD_NOT_FOUND = "DSR Recored Not Found Successfully";
        //Candidates Meassage
        public const string Candidate_Add = "Candidate Add Successfully";
        public const string Candidate_Updated = "Candidate Updated Successfully";
        public const string Candidate_Not_Found = "Candidate Not Found";
        public const string Candidate_Found = "Candidates  Found";
        public const string Candidate_Deleted = "Candidate Deleted Successfully";
        public const string Candidate_Not_Deleted = "Candidate Deleted Failed";

        //Attendance Messages
        public const string Attendance_Submitted = "Attendance Submitted Successfully";
        public const string Attendance_Entrytime_Already_Exists = "Attendance Entry Time Already Exists";
        public const string Attendance_Exittime_Already_Exists = "Attendance Exit Time Already Exists";
        public const string Attendance_Record_Exists = "Attendance Record Exists";
        public const string No_Attendance_Record_Exists = "No Attendance Record Exists";

        //Feedback Messages
        public const string Feedback_Submitted = "Feedback Submitted Successfully";
        public const string Feedback_Not_Submitted = "Feedback Not Submitted";
        public const string User_Feedback_Record_Exists = "User Feedback Exists";
        public const string No_User_Feedback_Record_Exists = "No User Feedback Exists";

    }

    }
