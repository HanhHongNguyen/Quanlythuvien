using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LoginDAO : DataProvider
    {
        public bool Login(Account acc)
        {
            string sql = "SELECT COUNT (Username) FROM Users_taolao WHERE UserName = '" + acc.Username + "' AND Password = '" + acc.Password + "'";
            int number;
            try
            {
                number = myExecuteScalar(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            if (number > 0)
                return true;
            else
                return false;
        }
    }
}
