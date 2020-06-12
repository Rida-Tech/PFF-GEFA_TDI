using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PFF_GEFA_TDI.BL
{
    class Groupe
    {
        public DataTable ListeGroupe()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ListeGroupe", null);
            dal.Close();
            return dt;
        }

        public void Ajouter_Groupe(int id, string groupe, int filiere,int effectife,string niveau)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@Groupe", SqlDbType.VarChar, 10);
            param[1].Value = groupe;

            param[2] = new SqlParameter("@Filiere", SqlDbType.Int);
            param[2].Value = filiere;

            param[3] = new SqlParameter("@Effectife", SqlDbType.Int);
            param[3].Value = effectife;

            param[4] = new SqlParameter("@Niveau", SqlDbType.VarChar, 11);
            param[4].Value = niveau;

            dal.ExecuteCommand("Ajouter_Groupe", param);
            dal.Close();

        }

        public DataTable VerifierIDGroupe(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            dt = dal.SelectData("VerifierIDGroupe", param);
            dal.Close();
            return dt;
        }
        public DataTable RechercherGroupe(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 80);
            param[0].Value = ID;
            dt = dal.SelectData("RechercherGroupe", param);
            dal.Close();
            return dt;
        }

        public void SupprimerGroupe(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 10);
            param[0].Value = id;

            dal.ExecuteCommand("SupprimerGroupe", param);
            dal.Close();

        }
        public void ModifierGroupe(int id, string groupe, int filiere, int effectife, string niveau)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@Groupe", SqlDbType.VarChar, 10);
            param[1].Value = groupe;

            param[2] = new SqlParameter("@Filiere", SqlDbType.Int);
            param[2].Value = filiere;

            param[3] = new SqlParameter("@Effectife", SqlDbType.Int);
            param[3].Value = effectife;

            param[4] = new SqlParameter("@Niveau", SqlDbType.VarChar, 11);
            param[4].Value = niveau;

            dal.ExecuteCommand("ModifierGroupe", param);
            dal.Close();

        }
    }
}
