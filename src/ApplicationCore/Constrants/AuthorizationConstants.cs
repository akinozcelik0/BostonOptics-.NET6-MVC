﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Constrants
{
    public class AuthorizationConstants
    {
        public const string DEFAULT_DEMO_USER = "demouser@example.com";
        public const string DEFAULT_ADMIN_USER = "admin@example.com";
        public const string DEFAULT_PASSWORD = "P@ssword1";

        public static class Roles
        {
            public const string ADMINISTRATOR = "Admin";
        }

    }

   
}
