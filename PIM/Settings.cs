using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class Settings : Form
    {
        public string defaultTheme = "Claro";
        public Settings()
        {
            InitializeComponent();
            
        }

        private void Settings_Load()
        {

        }


        private void selectTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTema.Text = Convert.ToString(selectTheme.SelectedItem);
            this.defaultTheme = Convert.ToString(selectTheme.SelectedItem); 
        }

        private void btnApplySettings_Click(object sender, EventArgs e)
        {

        }
    }
}
