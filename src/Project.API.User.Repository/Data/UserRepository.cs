using Dapper;
using MySql.Data.MySqlClient;
using Project.API.User.Business.Interface.Repositories;
using Project.API.User.Repository.Queries;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.API.User.Repository.Data
{
    /// <summary>
    /// This class represents the base access to the user
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private string _connection;

        public UserRepository(string connection)
        {
            _connection = connection;
        }

        public void Save()
        {
            using (var conexao = new MySqlConnection(_connection))
            {
                conexao.Execute(UserQuery.Save);
            }
        }

        public string GetUser(long userCode)
        {
            var users = new List<string>() { "User 1", "User 2", "User 3" };
            return users.FirstOrDefault(k => k.Contains(userCode.ToString()));
        }
    }
}
