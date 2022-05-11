using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapeAPi.Data
{
    /// <summary>Base repository type, which contains common connection, transaction and type handling code.</summary>
    public abstract class RepositoryBase
    {
        private const string ConnectionStringName = "ConnectionStrings:LiveDatabase";

        public RepositoryBase(IConfiguration configuration)
        {
            ConnectionString = configuration[ConnectionStringName];
            GetConnection = () => new SqlConnection(ConnectionString);
        }

        private string connectionString;

        /// <summary>Gets or sets the database connection string.</summary>
        protected string ConnectionString
        {
            get { return connectionString ?? throw new InvalidOperationException($"{nameof(ConnectionString)} is null"); }
            set { connectionString = value; }
        }

        /// <summary>Gets or sets the function to execute to create and open a connection to the database.</summary>
		protected virtual Func<IDbConnection> GetConnection { get; set; }
    }
}
