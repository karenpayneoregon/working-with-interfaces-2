using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Models;

namespace Playground.Classes
{
    class SqlOperations
    {
        private static readonly string _connectionString = "TODO";

        /// <summary>
        /// For comparision against <see cref="IFormatProvider"/>
        /// </summary>
        public static bool Insert(Person person)
        {
            const string sql = "INSERT INTO People" + 
                               "(FirstName, LastName, BirthDate) " +
                               "VALUES(@FirstName, @LastName,@BirthDate)";

            using var cn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand { Connection = cn, CommandText = sql };

            /*
             * Parameters are named, not positional
             */

            cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = person.BirthDate;

            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = person.LastName;

            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = person.FirstName;

            cn.Open();

            return cmd.ExecuteNonQuery() == 1;

        }
    }
}
