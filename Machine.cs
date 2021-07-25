using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Razor
{
    public static class Machine
    {
        public static async Task Fire()
        {
            Console.Title = "Razor Finance Bank";

        PromptUsername:
            Console.WriteLine("Enter your login details\nEnter username");
            string username = Console.ReadLine();

            while (string.IsNullOrEmpty(username))
            {
                goto PromptUsername;
            }

            var userCredentials = Authentication.GetUserCredential(username);
            var accountData = Authentication.GetAccountData(username);

        PromptPassword:
            Console.WriteLine("Please Enter your Password");
            string password = Console.ReadLine();

            while (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Enter your correct Password");
                goto PromptPassword;
            }

            var isValidated = Authentication.IsValidated(await userCredentials, password);
            if (await isValidated)
            {
                foreach (var data in await accountData)
                {
                    Console.WriteLine($"Welcome Back {data.FirstName} {data.LastName}");
                    Console.WriteLine("Your details are:");
                    Console.WriteLine($"Email: {data.Email}");
                    Console.WriteLine("Account No: {0}****{1}", data.AccountNumber.ToString().Substring(0, 3), data.AccountNumber.ToString()[7..]);
                    Console.WriteLine($"Account Balance: ${data.Balance:n}");
                    Console.WriteLine("BVN: {0}*****{1}", data.BVN.ToString().Substring(0, 3), data.BVN.ToString()[8..]);
                    Console.WriteLine($"Branch: {data.Address}");

                }

            }
            else
            {
                Console.WriteLine("Invalid Credentials! Try Again!");
                goto PromptUsername;

            }
            {

            }
        }
    }
}
