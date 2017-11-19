﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnF;
namespace Web.Repository
{
    public class UserRepository
    {

        public static bool CheckAdminRole(string userName)
        {
            DoGoMyNgheEntities db = new DoGoMyNgheEntities();
            var user = db.UserRoles.Where(p => p.UserName == userName).First();
            if (user.Role == 1)
            {
                return true;
            }
            return false;
        }
    }
}
