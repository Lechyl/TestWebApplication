using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApplication.Data
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageBody { get; set; }
        public User User { get; set; }
    }
}
