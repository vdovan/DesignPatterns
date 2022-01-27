using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string providerName = "MySql";
            IDbContext dbContext =  DbContextFactory.CreateDbContext(providerName);

            if(dbContext == null)
            {
                Console.WriteLine("dbContext can't be null");
            }
            else
            {
                Console.WriteLine(dbContext.Open());
                Console.WriteLine(dbContext.Close());
            }

        }
    }

   
}
