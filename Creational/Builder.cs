namespace DesignPatterns
{
    public class DbCommand
    {
        public string DbType { get; set; }
        public string DbConnection { get; set; }
        public string DbCommandType { get; set; }

        public string GetDbCommandInfo()
        {
            return string.Format("DbType: {0}, Connection: {1}, CommandType: {2}",
            this.DbType, this.DbConnection, this.DbCommandType);
        }
    }

    public abstract class DbCommandBuilder
    {
        protected DbCommand commandObject;
        public abstract void SetDbType();
        public abstract void SetDbConnection();
        public abstract void SetDbCommandType();

        public void CreateNewDbCommand()
        {
            commandObject = new DbCommand();
        }
        public DbCommand GetDbCommand()
        {
            return commandObject;
        }

    }

    public class SqlCommand : DbCommandBuilder
    {
        public override void SetDbCommandType()
        {
            commandObject.DbCommandType = "text or store procedure";
        }

        public override void SetDbConnection()
        {
            commandObject.DbConnection = "MsSql connection";
        }

        public override void SetDbType()
        {
            commandObject.DbType = "MsSql";
        }
    }

    public class OracleCommand : DbCommandBuilder
    {
        public override void SetDbCommandType()
        {
            commandObject.DbCommandType = "text or store procedure";
        }

        public override void SetDbConnection()
        {
            commandObject.DbConnection = "MsSql connection";
        }

        public override void SetDbType()
        {
            commandObject.DbType = "Oracle";
        }
    }

    public class DbCommandDirector
    {
        public DbCommand Build(DbCommandBuilder builder)
        {
            builder.CreateNewDbCommand();
            builder.SetDbType();
            builder.SetDbConnection();
            builder.SetDbCommandType();

            return builder.GetDbCommand();

        }
    }
}