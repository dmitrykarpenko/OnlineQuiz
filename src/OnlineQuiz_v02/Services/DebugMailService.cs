using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz_v02.Services
{
    public class DebugMailService : IMailService
    {
        public void SendMail(string to, string from, string subject, string body)
        {
            Debug.Write($"Mail sent: to: {to}, from: {from}, subject: {from}, body: {body}");
        }
    }
}
