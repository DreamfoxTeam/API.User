using System;
using System.Collections.Generic;
using System.Text;

namespace Project.API.User.Repository.Queries
{
    internal static class UserQuery
    {
        public static string Save = "INSERT INTO User (Login, Password) VALUES (@Login, @Password);";
    }
}
