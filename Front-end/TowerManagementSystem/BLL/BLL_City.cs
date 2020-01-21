using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.NewWebServices;


namespace BLL
{
    public class BLL_City
    {

        NewWebServices.WB_Tower ServiceObject = new NewWebServices.WB_Tower();

        public string LoadAllCity()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string str = ServiceObject.LoadAllCity();
            return str;
        }

        public bool SaveRecord(NewWebServices.BE_City NewBEObj)
        {
            bool IsSave = false;
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            IsSave = ServiceObject.AddCity(NewBEObj);
            return IsSave;
        }

        public bool UpdateRecord(NewWebServices.BE_City NewBEobj)
        {
            bool IsUpdate = false;
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            IsUpdate = ServiceObject.UpdateCity(NewBEobj);
            return IsUpdate;
        }

        public string DuplicationCheck(string name)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string Str = ServiceObject.DuplicationCheckCity(name);
            return Str;
        }

        public string GetCityIDByCityValue(int CityID)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string Str = ServiceObject.GetCityByCityID(CityID);
            return Str;
        }

        public string GetMaxCityID()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string MaXID = ServiceObject.GetMaxIDCity();
            return MaXID;
        }


    }
}
