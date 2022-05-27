using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace S7SteveCarvajal.Models
{
    class DbModel
    {
        MySqlConnection conn;

        public void Conectar()
        {
            conn = new MySqlConnection("server=localhost;user id=root;database=s7_tutorias;password=1234");
            conn.Open();
        }

        public void Desconectar()
        {
            conn.Close();
        }

        public void EjecutarSql(String consulta)
        {
            MySqlCommand con = new MySqlCommand(consulta, conn);
            int filasAfectadas = con.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Operación realizada correctamente", "La BD ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No se ha conectado a la BD", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
