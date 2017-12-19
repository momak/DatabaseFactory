using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFactory;

namespace DatabaseTest
{
    class ComicsManager : DataWorker
    {
        public  void GetComics()
        {
            using (IDbConnection connection = database.CreateOpenConnection())
            {
                using (IDbCommand command = database.CreateStoredProcCommand("SelectComics", connection))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        // ...
                    }
                }
            }
        }
    }
}
