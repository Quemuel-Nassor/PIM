using System;
using System.Drawing;
using System.Windows.Forms;

namespace PIM.Views
{
    public partial class Home : Form
    {
        private Form activeForm;


        public Home()
        {
            InitializeComponent();
        }

        private void FormShow(Form form)
        {
            ActiveFormClose();
            this.activeForm = form;
            form.TopLevel = false;
            panelContentForm.Controls.Add(form);
            form.BringToFront();
            form.Show();

        }

        private void ActiveFormClose()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void ActiveButton(Button activeForm)
        {
            foreach (Control control in mainPanel.Controls)
            {
                control.ForeColor = Color.White;
                activeForm.ForeColor = Color.Orange;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            FormShow(new Profile());

            bool isAdmin = true;

            if (!isAdmin)
            {
                btnRegisterEmployees.Visible = false;
                btnSettings.Visible = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            FormShow(new Profile());
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ActiveButton(btnEmployees);
            FormShow(new Employees());
        }

        private void btnRegisterEmployees_Click(object sender, EventArgs e)
        {
            ActiveButton(btnRegisterEmployees);
            FormShow(new RegisterEmployees());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // para fechar o form dentro dele this.Close()
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSettings);
            FormShow(new Settings());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
