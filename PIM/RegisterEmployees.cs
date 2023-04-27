using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PIM
{
    public partial class RegisterEmployees : Form
    {

        private MySqlConnection _connection;

        public RegisterEmployees()
        {
            InitializeComponent();
        }

        private void createEmployees()
        {
            try
            {
                _connection = new MySqlConnection(PIM.Database.Connection.stringConnection);

                _connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _connection;

                //string insertEmployee = $"INSERT INTO funcionario (nome, email, celular, cpf, senha, idCargo, idPermissao) VALUES ('{inputName.Text}', '{inputEmail.Text}', '{inputPhone.Text}', '{inputCPF.Text}', '{inputPassword.Text}', {selectOffice.SelectedItem}, {selectPermition.SelectedItem})";
                string insertEmployee = $"INSERT INTO `holerite_pim`.`funcionario` (`idPermissao`, `idCargo`, `nome`, `email`, `celular`, `cpf`, `senha`) VALUES ({selectPermition.SelectedIndex + 1}, {selectOffice.SelectedIndex + 1}, '{inputName.Text}', '{inputEmail.Text}', '{inputPhone.Text}', '{inputCPF.Text}', '{inputPassword.Text}');";

                //cmd.CommandText = "INSERT INTO funcionario (nome, email, celular, cpf, senha, userAdmin) " +
                //                    "VALUES (@nome, @email, @celular, @cpf, @senha, @userAdmin) ";

                //cmd.Parameters.AddWithValue("@nome", inputName.Text);
                //cmd.Parameters.AddWithValue("@email", inputEmail.Text);
                //cmd.Parameters.AddWithValue("@celular", inputPhone.Text);
                //cmd.Parameters.AddWithValue("@cpf", inputCPF.Text);
                //cmd.Parameters.AddWithValue("@senha", inputPassword.Text);
                //cmd.Parameters.AddWithValue("@permissao", selectPermition.SelectedItem);
                //cmd.Parameters.AddWithValue("@userAdmin", selectPermition.SelectedItem);

                cmd.CommandText = insertEmployee;

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario Criado Com Sucesso!",
                "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFields();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { _connection.Close(); }

        }

        private void clearFields()
        {

        }


        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectOffice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectPermition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createEmployees();
        }
    }
}
