using System;

namespace Project.API.User.Business.Messages.Requests
{
    /// <summary>
    /// This class contains the properties received by the client.
    /// </summary>
    public class UserRequest
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Fullname { get; set; }

        public DateTime Register { get; set; }

        public string Email { get; set; }
    }
}
