using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project
{
    class smtpClient
    {
        public string Host { get; set; }

        public System.Net.NetworkCredential Credentials { get; set; }

        public bool EnableSs1 { get; set; }

        public int Port { get; set; }

        internal void Send(System.Net.Mail.MailMessage mesg)
        {
            throw new NotImplementedException();
        }
    }
}
