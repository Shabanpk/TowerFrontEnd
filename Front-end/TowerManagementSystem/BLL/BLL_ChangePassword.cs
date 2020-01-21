using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
   public class BLL_ChangePassword
    {
       NewWebServices.WB_Tower ServiceObject = new NewWebServices.WB_Tower();

       public int ValidatePassword(string OldPassword, int UserId)
       {
           int integer = -1;
           try
           {
               if (OldPassword != null)
               {

                   bool IsValid = false;
                   ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
                   IsValid = ServiceObject.ValidatePassword(OldPassword, UserId);
                   if (IsValid)
                       integer = 0;
                   else
                       integer = 1;
               }
           }
           catch (Exception ex)
           {
               integer = 2;
           }
           return integer;
       }

       public bool PasswordMatch(string newPass, string retypepass)
       {
           bool IsMatch = false;
           if (newPass == retypepass)
           {
               IsMatch = true;
           }
           else
           {
               IsMatch = false;

           }

           return IsMatch;
       }

       public bool ChangePassword(string NewPassword, int UserID)
       {
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
           bool IsChange = ServiceObject.ChangePassword(NewPassword, UserID);
           return IsChange;
       }

    }
}
