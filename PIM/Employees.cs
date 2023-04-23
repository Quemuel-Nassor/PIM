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
    public partial class Employees : Form
    {
        private MySqlConnection _connection;

        public Employees()
        {
            InitializeComponent();

            lst_funcionarios.View = View.Details;
            lst_funcionarios.LabelEdit = true;
            lst_funcionarios.AllowColumnReorder = true;
            lst_funcionarios.FullRowSelect = true;
            lst_funcionarios.GridLines = true;

            lst_funcionarios.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_funcionarios.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_funcionarios.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            lst_funcionarios.Columns.Add("Celular", 150, HorizontalAlignment.Left);
            lst_funcionarios.Columns.Add("CPF", 150, HorizontalAlignment.Left);
            lst_funcionarios.Columns.Add("Senha", 150, HorizontalAlignment.Left);
            lst_funcionarios.Columns.Add("isAdmin", 150, HorizontalAlignment.Left);


        }

        private void getAllEmployees()
        {
            try
            {
                _connection = new MySqlConnection(PIM.Database.Connection.stringConnection);

                _connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _connection;

                cmd.CommandText = "SELECT * FROM pessoa";

                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                lst_funcionarios.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6)
                    };

                    lst_funcionarios.Items.Add(new ListViewItem(row));
                }
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
            finally { 
                _connection.Close();
            }
        }

        private void createEmployees()
        {
            try
            {
                _connection = new MySqlConnection(PIM.Database.Connection.stringConnection);

                _connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _connection;


                cmd.CommandText = "INSERT INTO pessoa (nome, email, celular, cpf, senha, userAdmin) " +
                                    "VALUES (@nome, @email, @celular, @cpf, @senha, @userAdmin) ";

                cmd.Parameters.AddWithValue("@nome", textNome.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@celular", textCelular.Text);
                cmd.Parameters.AddWithValue("@cpf", textCPF.Text);
                cmd.Parameters.AddWithValue("@senha", textSenha.Text);
                cmd.Parameters.AddWithValue("@userAdmin", textAdmin.Text);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Inseridos com Sucesso!",
                "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                clearFields();
                getAllEmployees();
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

        private void updateEmployees(int employeesID)
        {
            try {

                _connection = new MySqlConnection(PIM.Database.Connection.stringConnection);

                _connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _connection;

                cmd.CommandText = "UPDATE pessoa SET nome=@nome, email=@email, celular=@celular, cpf=@cpf, senha=@senha, userAdmin=@userAdmin " + "WHERE id=@id ";
                cmd.Parameters.AddWithValue("@nome", textNome.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@celular", textCelular.Text);
                cmd.Parameters.AddWithValue("@cpf", textCPF.Text);
                cmd.Parameters.AddWithValue("@senha", textSenha.Text);
                cmd.Parameters.AddWithValue("@userAdmin", textAdmin.Text);
                cmd.Parameters.AddWithValue("@id", employeesID);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Atualizados com Sucesso!",
                "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFields();
                getAllEmployees();

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
            finally { 
                _connection.Close();
            }

        }

        private void deleteEmployees(int employeesID)
        {
            try
            {
                DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir o registro?",
                                                    "Ops, tem certeza?",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (conf == DialogResult.Yes)
                {
                    _connection = new MySqlConnection(PIM.Database.Connection.stringConnection);

                    _connection.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = _connection;

                    cmd.CommandText = "DELETE FROM pessoa WHERE id=@id";

                    cmd.Parameters.AddWithValue("@id", employeesID);

                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados exclu�dos com Sucesso!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearFields();
                    getAllEmployees();
                }

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
            finally { 
                _connection.Close();
            }
        }

        private void clearFields()
        {
            id_funcionario_selecionado = null;

            textNome.Text = String.Empty;
            textEmail.Text = "";
            textCelular.Text = "";
            textCPF.Text = "";
            textSenha.Text = "";
            textAdmin.Text = "";

            textNome.Focus();

            button4.Visible = false;
        }
    }
}
