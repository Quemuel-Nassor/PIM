using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PIM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DBConect())
            {
                MessageBox.Show("Conexao feita com sucesso =)");
            }
        }

        private bool DBConect()
        {

            var result = false;
            try
            {
                using (var cn = new MySqlConnection(Conn.stringConnection))
                {
                    cn.Open();
                    result = true;
                }

            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show($"Falha: {ex.Message}");
            }

            return result;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseEndHover(object sender, EventArgs e)
        {

        }

    }
}
