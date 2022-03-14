using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenApi
{
    public sealed class NordigenApiException : Exception
    {
        public NordigenApiException(string message) : base(message)
        {

        }
    }
}
