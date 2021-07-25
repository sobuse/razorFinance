using System;
using System.Collections.Generic;
using System.Text;

namespace Razor
{
    public class Database
    {
        public static IEnumerable<Account> Accounts()
        {
            return new List<Account>() {

             new Account    { UserName = "SObuse", FirstName= "Sammy", LastName="Obuse", AccountNumber="1234567890", Address="45 unity street ikotun", Balance="200000",
                Gender="Male", BVN="221315677", Email="ehuerikenbaba@gmail.com"

            },
              new Account    { UserName = "EObuse", FirstName= "Ehimah", LastName="Obuse", AccountNumber="1234567456", Address="5 unity Estate Lekki", Balance="500000",
                Gender="Male", BVN="299315677", Email="Eobuse@gmail.com" },

               new Account    { UserName = "MObuse", FirstName= "Harriet", LastName="Obuse", AccountNumber="12345234156", Address="5 unity Estate Lekki", Balance="900000",
                Gender="Female", BVN="299315435", Email="hobuse@gmail.com" }

            };
        }

            public static IEnumerable<Credential> Credentials()
             {
                return new List<Credential>
            {
                new Credential{UserName = "ghidyon", FirstName = "Gideon", LastName = "Akunana", Password = "ghidyon"},
                new Credential{UserName = "kingalex", FirstName = "Alex", LastName = "Oz", Password = "kingalex"},
                new Credential{UserName = "queenlovey", FirstName = "Loveth", LastName = "Anosike", Password = "queenlovey"},
                
            };

            }
        }

    }
}
