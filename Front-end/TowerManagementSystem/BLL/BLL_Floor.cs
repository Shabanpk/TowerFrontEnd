using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
   public class BLL_Floor
    {

        NewWebServices.WB_Tower ServiceObject = new NewWebServices.WB_Tower();

        public string LoadAllFloor()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string str = ServiceObject.LoadAllFloor();
            return str;
        }

        public string LoadAllFloorCombo()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string str = ServiceObject.LoadAllFloorCombo();
            return str;
        }
        public bool SaveRecord(NewWebServices.BE_Floor NewBEObj)
        {
            bool IsSave = false;
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            IsSave = ServiceObject.AddFloor(NewBEObj);
            return IsSave;
        }

        public bool UpdateRecord(NewWebServices.BE_Floor NewBEobj)
        {
            bool IsUpdate = false;
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            IsUpdate = ServiceObject.UpdateFloor(NewBEobj);
            return IsUpdate;
        }

        public string DuplicationCheck(string Floorname)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string Str = ServiceObject.DuplicationCheckFloorName(Floorname);
            return Str;
        }

        public string GetFloorByID(int FloorID)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string Str = ServiceObject.GetFloorByID(FloorID);
            return Str;
        }

        public string GetMaxFloorID()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string MaXID = ServiceObject.GetMaxIDFloor();
            return MaXID;
        }

        public string LoadBuildingIDByFloorID(int FloorID)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string MaXID = ServiceObject.LoadBuildingIDByFloorID(FloorID);
            return MaXID;
        }


    }
}
