using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFactory;

namespace DatabaseTest
{
    class MyDatabaseLogic : DataWorker
    {
        public void LoadFlowers()
        {
            using (IDbConnection connection = database.CreateOpenConnection())
            {
                using (IDbCommand command = database.CreateCommand("SELECT * FROM comics", connection))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        // read flowers and process ...
                    }
                }
            }
        }
    }
}
