using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserDirectory.Api.Models;


namespace UserDirectory.Api.Data
{
    public class UserStore
    {
        public static List<User> Users { get; set; } = new List<User>();

        public static int NextId = 1;
    }
}