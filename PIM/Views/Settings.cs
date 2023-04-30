using System;
using System.Windows.Forms;

namespace PIM.Views
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
