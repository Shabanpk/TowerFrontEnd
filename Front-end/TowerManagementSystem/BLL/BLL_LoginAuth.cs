using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
   public class BLL_LoginAuth
    {
      // liveServicesURL.WB_Tower ServiceObject = new liveServicesURL.WB_Tower();
      // NewWebServices.WB_Tower ServiceObject = new NewWebServices.WB_Tower();
       NewWebServices.WB_Tower ServiceObject = new NewWebServices.WB_Tower();

       //liveServicesURL.WB_Tower ServiceObject = new liveServicesURL.WB_Tower();

       public string LoginAuthorization(string UserName, string Password)
       {
           string Loginstr = "";
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
           Loginstr = ServiceObject.LoginAuth(UserName, Password);
           return Loginstr;
       }

       public string LoadUserRight(string UserName)
       {
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
          // ServiceObject.Url = Configurations.GetCurrentUrl();
           string Right = ServiceObject.LoadUserRights(UserName);
           return Right;
       }

       public string GetUserMenuByUserID(int UserID)
       {
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
           string UserMenuByID = ServiceObject.GetUserMenuByUserID(UserID);
           return UserMenuByID;
       }

    }
}
