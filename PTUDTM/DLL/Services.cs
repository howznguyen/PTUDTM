﻿using DLL.Service;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Services
    {

        private static BOOKCOMMUNITYEntities db = new BOOKCOMMUNITYEntities();

        public static BookService book = new BookService(db);

        public static AuthService auth = new AuthService(db);

        public static UserService user = new UserService(db);

        public static CategoryService category = new CategoryService(db);
    }
}
