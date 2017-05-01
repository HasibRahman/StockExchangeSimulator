using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User;
using StockUserDataAccessLayer;
namespace StockUserBusinessLogicLayer
{
    public class BusinessLayer
    {
        DataLayer dataLayer = new DataLayer();
        public bool Register(Users user)
        {
            dataLayer.Register(user);
            return true;
        }
    }
}
