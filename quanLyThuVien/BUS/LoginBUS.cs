using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;

namespace BUS
{
    public class LoginBUS
    {
        public bool Login(Account acc)
        {
            try
            {
                return new LoginDAO().Login(acc);
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }
    }
}
