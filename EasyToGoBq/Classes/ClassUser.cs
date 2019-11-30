using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyToGoBq.Forms;

namespace EasyToGoBq.Classes
{
    public class User
    {
        private static User _instance;

        public static User Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new User();
                }
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public int Id { get; set; }

        public int IdSession { get; set; }

        public string Username { get; set; }

        public string UsernameSession { get; set; }

        public string Password { get; set; }

        public string PasswordSession { get; set; }

        public void UpdateFormMain()
        {
             FormMain.Instance.RefreshOnlineStatus();
        }

        public bool IsAuthenticate()
        {
            return Instance.UsernameSession != null ? true : false;
        }
    }
}
