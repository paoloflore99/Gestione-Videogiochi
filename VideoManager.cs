using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Videogiochi
{
    public class VideoManager
    {
        private const string CHIAVE = "Data Source=localhost;Initial Catalog=db-videogames-query;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public static void delite(long id)
        {
            using SqlConnection connection = new SqlConnection(CHIAVE) { };
            connection.Open();
            connection.Close();
        }
    }

    public abstract class ciao
    {
    }
}
