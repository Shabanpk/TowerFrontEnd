using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
   public class BLL_Billing
    {

       // liveServicesURL.WB_Tower ServiceObject = new liveServicesURL.WB_Tower();
       //liveServicesURL.WB_Tower ServiceObject = new liveServicesURL.WB_Tower();
       NewWebServices.WB_Tower ServiceObject = new NewWebServices.WB_Tower(); 
       public string LoadAllBillgSearchOnClickButton()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string str = ServiceObject.LoadAllBillgSearchOnClickButton();
            return str;
        }

        public string LoadOfficesForBilling()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string str = ServiceObject.LoadOfficesForBilling();
            return str;
        }

        public string GetMaxBillID()
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string str = ServiceObject.GetMaxBillID();
            return str;
        }

        public string GetBillingByID(int BillingID)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string str = ServiceObject.GetBillingByID(BillingID);
            return str;
        }

        public string LoadofficeDetailsByID(int OfficeID)
        {
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            string str = ServiceObject.LoadofficeDetailsByID(OfficeID);
            return str;
        }

        public bool SaveRecord(NewWebServices.BE_Billing NewBEObj)
        {
            bool IsSave = false;
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            IsSave = ServiceObject.AddBilling(NewBEObj);
            return IsSave;
        }

        public bool UpdateRecord(NewWebServices.BE_Billing NewBEobj)
        {
            bool IsUpdate = false;
            ServiceObject.AuthHeaderValue = new NewWebServices.AuthHeader { Username = Configurations.UserName, Password = Configurations.Password };
            IsUpdate = ServiceObject.UpdateBilling(NewBEobj);
            return IsUpdate;
        }

    }
}
