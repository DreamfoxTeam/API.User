using System;
using System.Collections.Generic;
using System.Text;

namespace Project.API.User.Business.Interface.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// This method saves the user.
        /// </summary>
        void Save();

        /// <summary>
        /// This method will get the user name at repository. 
        /// It is mocked now.
        /// </summary>
        /// <param name="userId">User code</param>
        /// <returns>Return the user name</returns>
        string GetUser(long userCode);
    }
}
