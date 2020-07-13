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
       // CREATE PROC Ajouter_Examen @type varchar(30) @date varchar(30),@heurD varchar(10),@heurF varchar(80), @ID_epreuve varchar(10)
        public void Ajouter_Examen(string type, string groupe, int filiere, int effectife, string annee)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,20);
            param[0].Value = type;

            param[1] = new SqlParameter("@Groupe", SqlDbType.VarChar, 10);
            param[1].Value = groupe;

            param[2] = new SqlParameter("@Filiere", SqlDbType.Int);
            param[2].Value = filiere;

            param[3] = new SqlParameter("@Effectife", SqlDbType.Int);
            param[3].Value = effectife;

            param[4] = new SqlParameter("@Annee", SqlDbType.VarChar, 10);
            param[4].Value = annee;

            dal.ExecuteCommand("Ajouter_Groupe", param);
            dal.Close();

        }
    }
}
