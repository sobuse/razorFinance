using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Razor
{
    class Authentication
    {
        private static readonly IEnumerable<Account> _accounts = Database.Accounts();
        private static readonly IEnumerable<Credential> _credentials = Database.Credentials();

        public static async Task<List<Account>> GetAccountData(string username)
        {
            var accountData = _accounts.Where(Data => Data.username.Equals(username.ToLower())).ToList();
            return accountData;
        }
        public static async Task<List<Credential>> GetUserCredential(string username)
        {
            List<Credential> userCredentials = _credentials.Where(data => data.username.Equals(username.ToLower())).ToList();
            return userCredentials;
        }
        public static async Task<bool> IsValidated(List<Credential> userCredentials, string password)
        {
            return userCredentials?.Any(data => data.Password.Equals(password)) ?? false;
        }

    }
}
