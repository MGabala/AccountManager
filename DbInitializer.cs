using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManager
{
    public class DbInitializer
    {
        public static void Initialize (AccountDbContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Accounts.Any())
            {
                return;
            }
            var accounts = new Account[]
            {
                new Account{Login="admin",Password="admin",Mail="admin@admin.pl"}
            };
            foreach(Account x in accounts)
            {
                context.Accounts.Add(x);
            }
            context.SaveChanges();
        }
    }
}
