using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ContAux.controller
{
    class conexion
    {
        private static String server = ConfigurationManager.AppSettings["server"];
        private static String database = ConfigurationManager.AppSettings["database"];
        private static String user = ConfigurationManager.AppSettings["user"];
        private static String pass = ConfigurationManager.AppSettings["pass"];

        public MySqlConnection conectar() {
            MySqlConnection response = null;
            String conexion = "SERVER="+ server + ";DATABASE="+ database+";UID="+user+";PASSWORD="+pass+";";

            try {
                MySqlConnection connection = new MySqlConnection(conexion);
                connection.Open();
                response = (connection.State == System.Data.ConnectionState.Open)?connection:null;
               
            }
            catch (Exception ex) {
                MessageBox.Show("Error al conectar: \n Revise su conexion a internet e intente de nuevo de lo contrario llame a soporte " + ex,"¡UPSS!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                response = null;
            }
            return response;
        }
        public Boolean desconectar(MySqlConnection connection) {
            Boolean response = false;
            try
            {
                connection.Close();
                response = (connection.State == System.Data.ConnectionState.Closed) ? true : false;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al cerrar conexion MySQL: " + ex, "¡UPSS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                response = false;
            }
            return response;
        }
    }
}
