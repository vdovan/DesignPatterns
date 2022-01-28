using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Builder
            DbCommand dbCommand;
            DbCommandDirector director = new DbCommandDirector();

            SqlCommand sqlCmd = new SqlCommand();
            dbCommand = director.Build(sqlCmd);
            PrintConsoleMessage(dbCommand.GetDbCommandInfo());

            OracleCommand oraCmd = new OracleCommand();
            dbCommand = director.Build(oraCmd);
            PrintConsoleMessage(dbCommand.GetDbCommandInfo());

            #endregion Builder
            #region Factory
            // string providerName = "MySql";
            // IDbContext dbContext =  DbContextFactory.CreateDbContext(providerName);

            // if(dbContext == null)
            // {
            //     Console.WriteLine("dbContext can't be null");
            // }
            // else
            // {
            //     Console.WriteLine(dbContext.Open());
            //     Console.WriteLine(dbContext.Close());
            // }
            #endregion Factory

            void PrintConsoleMessage(string message)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(Environment.NewLine);
                Console.ResetColor();
            }
        }
    }

   
}
