using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PFF_GEFA_TDI.BL
{
    class Examen
    {
        public DataTable ListExamen()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ListExamen", null);
            dal.Close();
            return dt;
        }
        public DataTable ID_Examen()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ID_Examen", null);
            dal.Close();
            return dt;
        }
        public DataTable liste_Surveille()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("liste_Surveille", null);
            dal.Close();
            return dt;
        }
        public DataTable list_Passer()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("list_Passer", null);
            dal.Close();
            return dt;
        }
        public DataTable List_Affecter()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("List_Affecter", null);
            dal.Close();
            return dt;
        }

        public void Ajouter_Examen(string type, string date , string debut, string fin, string epreuve)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@type", SqlDbType.VarChar,30);
            param[0].Value = type;

            param[1] = new SqlParameter("@date", SqlDbType.Date);
            param[1].Value = date;

            param[2] = new SqlParameter("@debut", SqlDbType.Time,0);
            param[2].Value = debut;

            param[3] = new SqlParameter("@fin", SqlDbType.Time,0);
            param[3].Value = fin;

            param[4] = new SqlParameter("@epreuve", SqlDbType.VarChar, 10);
            param[4].Value = epreuve;

            dal.ExecuteCommand("Ajouter_Examen", param);
            dal.Close();

        }
        public DataTable RechercherExamen(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 80);
            param[0].Value = ID;
            dt = dal.SelectData("RechercherExamen", param);
            dal.Close();
            return dt;
        }
        public void SupprimerExamen(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id;

            dal.ExecuteCommand("SupprimerExamen", param);
            dal.Close();

        }
        public void ModifierExamen(int id, string type, string date, string debut, string fin, string epreuve)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@type", SqlDbType.VarChar, 30);
            param[1].Value = type;

            param[2] = new SqlParameter("@date", SqlDbType.Date);
            param[2].Value = date;

            param[3] = new SqlParameter("@debut", SqlDbType.Time, 0);
            param[3].Value = debut;

            param[4] = new SqlParameter("@fin", SqlDbType.Time, 0);
            param[4].Value = fin;

            param[5] = new SqlParameter("@epreuve", SqlDbType.VarChar, 10);
            param[5].Value = epreuve;

            dal.ExecuteCommand("ModifierExamen", param);
            dal.Close();

        }
        public void SupprimerSurville(int idensg, int idgrp)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idensg", SqlDbType.Int);
            param[0].Value = idensg;

            param[1] = new SqlParameter("@idgrp", SqlDbType.Int);
            param[1].Value = idgrp;

            dal.ExecuteCommand("SupprimerSurville", param);
            dal.Close();

        }
       
        public void Ajouter_Surveille(int idensg,int idgrp)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idensg", SqlDbType.Int);
            param[0].Value = idensg;

            param[1] = new SqlParameter("@idgrp", SqlDbType.Int);
            param[1].Value = idgrp;

            dal.ExecuteCommand("Ajouter_Surveille", param);
            dal.Close();

        }
        public void Ajouter_Passer(int idexamen, int idgrp)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idexamen", SqlDbType.Int);
            param[0].Value = idexamen;

            param[1] = new SqlParameter("@idgrp", SqlDbType.Int);
            param[1].Value = idgrp;

            dal.ExecuteCommand("Ajouter_Passer", param);
            dal.Close();

        }
        public void SupprimerPasser(int idexamen, int idgrp)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idexamen", SqlDbType.Int);
            param[0].Value = idexamen;

            param[1] = new SqlParameter("@idgrp", SqlDbType.Int);
            param[1].Value = idgrp;

            dal.ExecuteCommand("SupprimerPasser", param);
            dal.Close();

        }
        public void Ajouter_Affecter(string numsalle, int idgrp)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@numsalle", SqlDbType.VarChar,10);
            param[0].Value = numsalle;

            param[1] = new SqlParameter("@idgrp", SqlDbType.Int);
            param[1].Value = idgrp;

            dal.ExecuteCommand("Ajouter_Affecter", param);
            dal.Close();

        }
        public void SupprimerAffecter(string numsalle, int idgrp)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@numsalle", SqlDbType.VarChar, 10);
            param[0].Value = numsalle;

            param[1] = new SqlParameter("@idgrp", SqlDbType.Int);
            param[1].Value = idgrp;

            dal.ExecuteCommand("SupprimerAffecter", param);
            dal.Close();

        }
    }
}
