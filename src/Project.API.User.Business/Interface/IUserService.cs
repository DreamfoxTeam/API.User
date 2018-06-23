using Project.API.User.Business.Messages.Requests;
using Project.API.User.Business.Messages.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.API.User.Business.Interface
{
    public interface IUserService
    {
        /// <summary>
        /// This method save the user.
        /// </summary>
        /// <param name="request">Object with user values</param>
        /// <returns>Return an object with a status of request</returns>
        UserResponse Save(UserRequest request);
    }
}
