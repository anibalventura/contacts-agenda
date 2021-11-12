using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class LoginService
    {
        public static LoginService Instance { get; } = new LoginService();

        public int? IdLogedUser { get; set; } = null;
    }
}
