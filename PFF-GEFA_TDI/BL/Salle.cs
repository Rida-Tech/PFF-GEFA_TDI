using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PFF_GEFA_TDI.BL
{
    class Salle
    {
        public DataTable ListeSalle()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ListeSalle", null);
            dal.Close();
            return dt;
        }

        public void Ajouter_Salle(string num, string type,int capacite)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Num_salle", SqlDbType.VarChar,10);
            param[0].Value = num;

            param[1] = new SqlParameter("@Type_salle", SqlDbType.VarChar, 20);
            param[1].Value = type;

            param[2] = new SqlParameter("@capacite", SqlDbType.Int);
            param[2].Value = capacite;

            dal.ExecuteCommand("Ajouter_Salle", param);
            dal.Close();

        }

        public DataTable VerifierIDSalle(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            dt = dal.SelectData("VerifierIDSalle", param);
            dal.Close();
            return dt;
        }
        public DataTable RechercherSalle(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 80);
            param[0].Value = ID;
            dt = dal.SelectData("RechercherSalle", param);
            dal.Close();
            return dt;
        }

        public void SupprimerSalle(string id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar,10);
            param[0].Value = id;

            dal.ExecuteCommand("SupprimerSalle", param);
            dal.Close();

        }
        public void ModifierSalle(string num, string type,int capacite)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Num_salle", SqlDbType.VarChar,10);
            param[0].Value = num;

            param[1] = new SqlParameter("@Type_salle", SqlDbType.VarChar, 20);
            param[1].Value = type;

            param[2] = new SqlParameter("@capacite", SqlDbType.Int);
            param[2].Value = capacite;

            dal.ExecuteCommand("ModifierSalle", param);
            dal.Close();

        }
    }
}

