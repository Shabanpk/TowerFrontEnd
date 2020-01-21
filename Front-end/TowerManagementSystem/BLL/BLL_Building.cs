using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
   public class BLL_Building
    {

       NewWebServices.WB_Tower ServiceObject = new NewWebServices.WB_Tower();

       public string LoadAllBuilding()
       {
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
           string str = ServiceObject.LoadAllBuilding();
           return str;
       }

       public string LoadAllBuildingCombo()
       {
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
           string str = ServiceObject.LoadAllBuildingCombo();
           return str;
       }

       public bool SaveRecord(NewWebServices.BE_Building NewBEObj)
       {
           bool IsSave = false;
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
           IsSave = ServiceObject.AddBuilding(NewBEObj);
           return IsSave;
       }

       public bool UpdateRecord(NewWebServices.BE_Building NewBEobj)
       {
           bool IsUpdate = false;
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
           IsUpdate = ServiceObject.UpdateBuilding(NewBEobj);
           return IsUpdate;
       }

       public string DuplicationCheck(string name)
       {
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
           string Str = ServiceObject.DuplicationCheckBuildingName(name);
           return Str;
       }

       public string GetBuildingByID(int BuildingID)
       {
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
           string Str = ServiceObject.GetBuildingByID(BuildingID);
           return Str;
       }

       public string GetMaxBuildingID()
       {
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
           string MaXID = ServiceObject.GetMaxIDBuilding();
           return MaXID;
       }

       public string LoadCityByBuildingID(int BuildingID)
       {
           ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
           string MaXID = ServiceObject.LoadCityByBuildingID(BuildingID);
           return MaXID;
       }

    }
}
