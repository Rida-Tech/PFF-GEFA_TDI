using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PFF_GEFA_TDI.BL
{
    class Epreuve
    {
        public DataTable ListEpreuve()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ListeEpreuve", null);
            dal.Close();
            return dt;
        }
        public void Ajouter_Epreuve(string id, string epreuve,string variante)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_Epreuve", SqlDbType.VarChar);
            param[0].Value = id;

            param[1] = new SqlParameter("@Epreuve", SqlDbType.VarChar, 20);
            param[1].Value = epreuve;

            param[2] = new SqlParameter("@Variante", SqlDbType.VarChar, 10);
            param[2].Value = variante;

            dal.ExecuteCommand("Ajouter_Epreuve", param);
            dal.Close();

        }

        public DataTable VerifierIDEpreuve(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 10);
            param[0].Value = ID;
            dt = dal.SelectData("VerifierIDEpreuve", param);
            dal.Close();
            return dt;
        }

        public DataTable RechercherEpreuve(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 80);
            param[0].Value = ID;
            dt = dal.SelectData("RechercherEpreuve", param);
            dal.Close();
            return dt;
        }
        public void SupprimerEpreuve(string id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 10);
            param[0].Value = id;

            dal.ExecuteCommand("SupprimerEpreuve", param);
            dal.Close();

        }
        public void ModifierEpreuve(string id, string Epreuve,string variante)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 10);
            param[0].Value = id;

            param[1] = new SqlParameter("@Epreuve", SqlDbType.VarChar, 20);
            param[1].Value = Epreuve;

            param[2] = new SqlParameter("@Variante", SqlDbType.VarChar, 10);
            param[2].Value = variante;

            dal.ExecuteCommand("ModifierEpreuve", param);
            dal.Close();

        }
    }
}
