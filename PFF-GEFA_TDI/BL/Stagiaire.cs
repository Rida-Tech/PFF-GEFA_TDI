using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PFF_GEFA_TDI.BL
{
    class Stagiaire
    {
        public DataTable ListeStagiaire()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ListStagiaire", null);
            dal.Close();
            return dt;
        }

        public DataTable GroupeNiveau1()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GroupeNiveau1", null);
            dal.Close();
            return dt;
        }
        public DataTable GroupeNiveau2()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GroupeNiveau2", null);
            dal.Close();
            return dt;
        }
        public DataTable GroupeNiveau3()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GroupeNiveau3", null);
            dal.Close();
            return dt;
        }

        public void Ajouter_Stagiaire(int id, string nom, string prenom, string email, int groupe)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@nom", SqlDbType.VarChar, 30);
            param[1].Value = nom;

            param[2] = new SqlParameter("@prenom", SqlDbType.VarChar,30);
            param[2].Value = prenom;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar,80);
            param[3].Value = email;

            param[4] = new SqlParameter("@groupe", SqlDbType.Int);
            param[4].Value = groupe;

            dal.ExecuteCommand("Ajouter_Stagiaire", param);
            dal.Close();

        }

        public DataTable VerifierIDStagiaire(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            dt = dal.SelectData("VerifierIDStagiaire", param);
            dal.Close();
            return dt;
        }
        public DataTable RechercherStagiaire(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 80);
            param[0].Value = ID;
            dt = dal.SelectData("RechercherStagiaire", param);
            dal.Close();
            return dt;
        }

        public void SupprimerStagiair(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 10);
            param[0].Value = id;

            dal.ExecuteCommand("SupprimerStagiaire", param);
            dal.Close();

        }
        public void ModifierStagiaire(int id, string nom, string prenom, string email, int groupe)
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

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 80);
            param[3].Value = email;

            param[4] = new SqlParameter("@groupe", SqlDbType.Int);
            param[4].Value = groupe;

            dal.ExecuteCommand("ModifierStagiaire", param);
            dal.Close();

        }
    }
}
