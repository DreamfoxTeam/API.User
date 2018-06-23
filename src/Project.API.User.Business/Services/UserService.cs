using Project.API.User.Business.Interface;
using Project.API.User.Business.Interface.Repositories;
using Project.API.User.Business.Messages.Requests;
using Project.API.User.Business.Messages.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.API.User.Business.Services
{
    /// <summary>
    /// This class has methods related to the user domain.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Instance the object of the user repository
        /// </summary>
        /// <param name="repository"></param>
        public UserService(IUserRepository repository)
        {
            _userRepository = repository;
        }

        public UserResponse Save(UserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
