namespace DesignPatterns
{
    class DbContextFactory
    {
        public static IDbContext CreateDbContext(string providerName)
        {
            IDbContext dbContext = null;

            if(providerName == "MsSql")
            {
                dbContext = new MsSql();
            }
            else if(providerName == "MySql")
            {
                dbContext = new MySql();
            }
            else if(providerName == "Oracle")
            {
                dbContext = new Oracle();
            }

            return dbContext;
        }
    }
    interface IDbContext
    {
        string Open();
        string Close();
    }

    class MySql : IDbContext
    {
        public string Close()
        {
            return "This MySql was closed";
        }

        public string Open()
        {
            return "This MySql was opened";
        }
    }
    class Oracle : IDbContext
    {
        public string Close()
        {
            return "This Oracle was closed";
        }

        public string Open()
        {
            return "This Oracle was opened";
        }
    }

    class MsSql : IDbContext
    {
        public string Close()
        {
            return "This MsSql was closed";
        }

        public string Open()
        {
            return "This MsSql was opened";
        }
    }
}