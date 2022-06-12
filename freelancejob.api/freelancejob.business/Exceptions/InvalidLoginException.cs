using freelancejob.business.Enums.Reasons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancejob.business.Exceptions
{
    [Serializable]
    public class InvalidLoginException : Exception
    {
        /// <summary>
        /// InvalidActivationReason
        /// </summary>
        public InvalidLoginReason Code { get; set; }

        /// <summary>
        /// InvalidActivationException
        /// </summary>
        public InvalidLoginException()
        {
        }

        /// <summary>
        /// InvalidActivationException
        /// </summary>
        /// <param name="reason"></param>
        public InvalidLoginException(InvalidLoginReason reason)
        {
            Code = reason;
        }

        /// <summary>
        /// InvalidActivationException
        /// </summary>
        /// <param name="message"></param>
        public InvalidLoginException(string message) : base(message)
        {
        }

        /// <summary>
        /// InvalidActivationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public InvalidLoginException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// InvalidActivationException
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected InvalidLoginException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }
}
