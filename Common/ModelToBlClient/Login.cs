using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ModelToBlClient
{
   public class Login
    {
        public Login(int userId, string name, UserAuthType userAuthType)
        {
            UserId = userId;
            Name = name;
            UserAuthType = userAuthType;
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public UserAuthType UserAuthType { get; set; }

        public Login()
        {

        }
    }
}
