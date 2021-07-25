using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Razor
{
    public class Account
    {
        public string UserName { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AccountNumber { get; set; }
        public string BVN { get; set; }
        public string Balance { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
