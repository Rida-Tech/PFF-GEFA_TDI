using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PFF_GEFA_TDI.DAL
{
    class DataAccessLayer
    {
        SqlConnection con;

        //Ce constructeur est pour initialisé la connexion.
        public DataAccessLayer()
        {
            con = new SqlConnection(@"Server=.\SQLEXPRESS; Database=PFF_GEFA_TDI; integrated security=true");
        }

        //cette Méthode pour l'ouverture de connexion.
        public void Open()
        {
            if(con.State!=ConnectionState.Open)
            {
                con.Open();
            }
        }

        //Cette méthode pour la fermeture de connexon.
        public void Close()
        {
            if(con.State!=ConnectionState.Closed)
            {
                con.Close();
            }
        }

        //Cette méthode pour la lecture des données depuis la base des données
        public DataTable SelectData(string procedur_stocke, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procedur_stocke;

            if(param != null)
            {
                for(int i=0;i<param.Length;i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Cette méthode pour Modifier Ajouter Supprimer les données...
        public void ExecuteCommand(string procedur_stocke, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procedur_stocke;

            if (param != null)
            {
                    cmd.Parameters.AddRange(param);
            }

            cmd.ExecuteNonQuery();
        }
    }
}
