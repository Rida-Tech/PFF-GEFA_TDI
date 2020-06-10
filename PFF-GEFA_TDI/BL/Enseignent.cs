using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PFF_GEFA_TDI.BL
{
    class Enseignent
    {

        public DataTable ListEnseignent()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ListEnseignent", null);
            dal.Close();
            return dt;
        }

        public void AjouterEnseignent(int id, string nom, string prenom, string tel, string email)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@nom", SqlDbType.VarChar, 30);
            param[1].Value = nom;

            param[2] = new SqlParameter("@prenom", SqlDbType.VarChar, 30);
            param[2].Value = prenom;

            param[3] = new SqlParameter("@tel", SqlDbType.VarChar, 10);
            param[3].Value = tel;

            param[4] = new SqlParameter("@email", SqlDbType.VarChar, 80);
            param[4].Value = email;

            dal.ExecuteCommand("Ajouter_Ensg", param);
            dal.Close();

        }

        public DataTable VerifierID(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param =new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            dt = dal.SelectData("VerifierID", param);
            dal.Close();
            return dt;
        }
        public DataTable RechercherEnseignent(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,80);
            param[0].Value = ID;
            dt = dal.SelectData("RechercherEnseignent", param);
            dal.Close();
            return dt;
        }

    }
}
