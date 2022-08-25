using LinqToDB;
using LinqToDB.Configuration;
using MerakiCore.Domain;
using System.Collections.Generic;
using System.Linq;

namespace MerakiCore
{
    public class DBConnection : LinqToDB.Data.DataConnection
    {
        public DBConnection() : base("Meraki") { }

        public ITable<User> Users => this.GetTable<User>();
    }
    public class ConnectionStringSettings : IConnectionStringSettings
        {
            public string ConnectionString { get; set; }
            public string Name { get; set; }
            public string ProviderName { get; set; }
            public bool IsGlobal => false;
        }

        public class MySettings : ILinqToDBSettings
        {
            public IEnumerable<IDataProviderSettings> DataProviders
                => Enumerable.Empty<IDataProviderSettings>();

            public string DefaultConfiguration => "SqlServer";
            public string DefaultDataProvider => "SqlServer";

            public IEnumerable<IConnectionStringSettings> ConnectionStrings
            {
                get
                {
                    yield return
                        new ConnectionStringSettings
                        {
                            Name = "Meraki",
                            ProviderName = ProviderName.SqlServer,
                            ConnectionString =
                                @"Data Source=157.245.96.207;Initial Catalog=PlanAMatch;User Id=SA;Password=Meraki;"
                        };
                }
            }
        }
    
}
