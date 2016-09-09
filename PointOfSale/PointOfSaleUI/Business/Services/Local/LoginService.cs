using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    /// <summary>
    ///     Used to log in a user in the system
    /// </summary>
    public class LoginService : PointOfSaleService
    {

        private string username;

        private string password;

        public LoginService(string username,string password)
        {
            this.username = username;
            this.password = password;
        }

        protected sealed override void AccessControl()
        {
            /* Any users can access the Login service */
        }

        protected sealed override void Dispatch()
        {
            if(username == null || password == null)
            {
                throw new ArgumentNullException();
            }
            PointOfSaleRoot.GetInstance().Login(username, password);
        }
    }
}
