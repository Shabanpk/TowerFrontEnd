using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLL_UserManagement
    {
        NewWebServices.WB_Tower ServiceObject = new NewWebServices.WB_Tower();

        public int ValidateUser(string UserName)
        {
            int integer = -1;
            try
            {
                if (UserName != null)
                {
                    ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
                    bool IsValid = false;
                    IsValid = ServiceObject.ValidateUser(UserName);
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

        public string GetAllFormName()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string allform = ServiceObject.GetFormName();
            return allform;
        }

        public string DuplicationCheck(string name)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string Str = ServiceObject.DuplicateUser(name);
            return Str;
        }

        public bool AddUserManagement(NewWebServices.BE_UserManagement NewBEObj)
        {
            bool IsSave = false;
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            IsSave = ServiceObject.AddUserRights(NewBEObj);
            return IsSave;
        }

        public bool UpdateUserManagement(NewWebServices.BE_UserManagement NewBEObj)
        {
            bool IsSave = false;
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            IsSave = ServiceObject.UpdateUserRights(NewBEObj);
            return IsSave;
        }

        public string GetMaxUserID()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string MaXID = ServiceObject.GetMaxUserID();
            return MaXID;
        }

        public string GetUserDetail(int userID)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string Details = ServiceObject.GetUserDetail(userID);
            return Details;
        }

        public string GetUserRightsDetails(int userID)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string Details = ServiceObject.GetUserRightsDetails(userID);
            return Details;
        }

        public string LoadAllUsers()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string MaXID = ServiceObject.LoadAllUsers();
            return MaXID;
        }

    }
}
