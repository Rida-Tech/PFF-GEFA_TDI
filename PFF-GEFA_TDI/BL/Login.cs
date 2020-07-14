using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFF_GEFA_TDI.BL
{
    class Login
    {
        public DataTable Login_Method(string nom,string pass)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@nom", SqlDbType.VarChar,30);
            param[0].Value = nom;

            param[1] = new SqlParameter("@pass", SqlDbType.VarChar,30);
            param[1].Value = pass;
            dt = dal.SelectData("Login_Form", param);
            dal.Close();
            return dt;
        }
    }
}
