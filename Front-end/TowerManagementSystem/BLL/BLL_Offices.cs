using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
   public class BLL_Offices
    {

        NewWebServices.WB_Tower ServiceObject = new NewWebServices.WB_Tower();

        public string LoadAllOffices()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string str = ServiceObject.LoadAllOffice();
            return str;
        }

        public bool SaveRecord(NewWebServices.BE_Office NewBEObj)
        {
            bool IsSave = false;
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            IsSave = ServiceObject.AddOffice(NewBEObj);
            return IsSave;
        }

        public bool UpdateRecord(NewWebServices.BE_Office NewBEobj)
        {
            bool IsUpdate = false;
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            IsUpdate = ServiceObject.UpdateOffice(NewBEobj);
            return IsUpdate;
        }

        public string DuplicationCheck(string OfficeName)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string Str = ServiceObject.DuplicationCheckOfficeName(OfficeName);
            return Str;
        }

        public string GetOfficeByID(int OfficeID)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string Str = ServiceObject.GetOfficeByID(OfficeID);
            return Str;
        }

        public string LoadBuildingfromOfficesEdit(int OfficeID)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string Str = ServiceObject.LoadBuildingfromOfficesEdit(OfficeID);
            return Str;
        }

        public string LoadfloorByOfficeIDinEdit(int OfficeID)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string Str = ServiceObject.LoadfloorByOfficeIDinEdit(OfficeID);
            return Str;
        }

        public string GetMaxOfficeID()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string MaXID = ServiceObject.GetMaxOfficeID();
            return MaXID;
        }

        public string LoadfloorByBuildingID(int BuildingID)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string MaXID = ServiceObject.LoadfloorByBuildingID(BuildingID);
            return MaXID;
        }

        public string LoadAllBuildingforOffice()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string str = ServiceObject.LoadAllBuildingforOffice();
            return str;
        }
    }
}
