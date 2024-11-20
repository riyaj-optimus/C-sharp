using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
     class AuthManager
    {
        public void Login()
        {

        }
        public void Logout()
        {

        }
        public Boolean IsCurrentUserAuthenticated()
        {
            return true;
        }

        public Employee GetCurrentlyLogedInUser()
        {
            return new Employee();
        }
        //highly cohesive : strong strength of relationship
    }
}
