using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_LogIn
{
    public class SingletonSesion
    {
        private static SingletonSesion instance;
        private bool isLoggedIn;
        private SingletonSesion()
        {
            isLoggedIn = false;
        }
        public static SingletonSesion Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SingletonSesion();
                }
                return instance;
            }
        }
        public bool Login()
        {
            isLoggedIn = true;
            return true;
        }
        public void Logout()
        {
            isLoggedIn = false;
        }
        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }
    }
}
