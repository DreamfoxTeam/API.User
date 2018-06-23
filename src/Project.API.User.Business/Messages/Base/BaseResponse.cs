using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Project.API.User.Business.Messages.Base
{
    /// <summary>
    /// This class represents the base to response.
    /// </summary>
    public abstract class BaseResponse
    {
        public BaseResponse()
        {
            Messages = new List<string>();
        }

        /// <summary>
        /// notify if there were any errors in processing.
        /// </summary>
        [DataMember(Name = "isValid")]
        public bool IsValid
        {
            get
            {
                return !Messages.Any();
            }
        }

        /// <summary>
        /// Return error messages.
        /// </summary>
        [DataMember(Name = "messages")]
        public List<string> Messages { get; set; }
    }
}
