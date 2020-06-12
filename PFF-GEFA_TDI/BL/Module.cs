using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PFF_GEFA_TDI.BL
{
    class Module
    {
        public DataTable ListeModules()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ListeModules", null);
            dal.Close();
            return dt;
        }

        public void Ajouter_Module(int id, string module)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@module", SqlDbType.VarChar, 75);
            param[1].Value = module;

            dal.ExecuteCommand("Ajouter_Module", param);
            dal.Close();

        }

        public DataTable VerifierIDModule(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            dt = dal.SelectData("VerifierIDModule", param);
            dal.Close();
            return dt;
        }
        public DataTable RechercherModule(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 80);
            param[0].Value = ID;
            dt = dal.SelectData("RechercherModule", param);
            dal.Close();
            return dt;
        }

        public void SupprimerModule(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dal.ExecuteCommand("SupprimerModule", param);
            dal.Close();

        }
        public void ModifierModule(int id, string module)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@module", SqlDbType.VarChar, 75);
            param[1].Value = module;

            dal.ExecuteCommand("ModifierModule", param);
            dal.Close();

        }
    }
}
