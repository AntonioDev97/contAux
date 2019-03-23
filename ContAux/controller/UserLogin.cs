using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContAux.controller
{
    class UserLogin
    {
        public Boolean autentica(model.UserLogin usrMod) {
            Boolean response = false;
            conexion database = new conexion();
            try
            {
                MySqlConnection con = database.conectar();
                try
                {

                    MySqlDataReader reader = null;
                    String query = "SELECT usuario, passw FROM usuarios LIMIT 1";
                    MySqlCommand execQuery = new MySqlCommand(query, con);
                    reader = execQuery.ExecuteReader();
                    if (reader.HasRows)
                    {
                        seguridad security = new seguridad();
                        while(reader.Read())
                            response = (reader.GetString(0).ToLower().Equals(usrMod.User.ToLower()) && reader.GetString(1).Equals(security.Encriptar(usrMod.Password))) ? true : false;
                    }
                    database.desconectar(con);
                    query = String.Empty;
                    execQuery = null;
                    reader = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al autenticar usuario: " + ex, "¡UPSS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    database.desconectar(con);
                    response = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error de conexion: " + ex, "¡UPSS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                response = false;
            }
     
                
            return response;
        }
       
    }

}
