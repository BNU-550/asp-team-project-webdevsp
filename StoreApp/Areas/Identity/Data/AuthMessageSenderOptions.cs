using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Areas.Identity.Data
{
    public class AuthMessageSenderOptions
    {
        public readonly string SendGridKey = "";

        public AuthMessageSenderOptions()
        {
            VerifyKey();
        }

        private void VerifyKey()
        {
            if ((string.IsNullOrEmpty(SendGridKey)))
            {
                throw new NotImplementedException();
            }
        }
    }
}
