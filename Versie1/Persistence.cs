using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Versie1
{
    class Persistence
    {
        private string _connectionstring;

        public Persistence()
        {
            _connectionstring = "server=localhost;user id=root;Password='Test123';database=database";
        }

        public List<Aankoop> getEvaluatieFromDB()
        {
            List<Aankoop> lijst = new List<Aankoop>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand("select * from aankoop", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Aankoop eval = new Aankoop(Convert.ToInt32(dataReader["idAankoop"]), Convert.ToDouble(dataReader["Prijs"]), Convert.ToInt32(dataReader["Aantal"]));
                lijst.Add(eval);
            }

            conn.Close(); 
            return lijst; 
        }
    }
}
