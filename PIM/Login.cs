﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace PIM
{
    public partial class Login : Form
    {
        private MySqlConnection _connection;
        public Login()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tableContainerFormLogin = new System.Windows.Forms.TableLayoutPanel();
            this.bodyFormLogin = new System.Windows.Forms.Panel();
            this.labelPassLogin = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.brandFormLogin = new System.Windows.Forms.PictureBox();
            this.inputEmailLogin = new System.Windows.Forms.TextBox();
            this.inputPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tableContainerFormLogin.SuspendLayout();
            this.bodyFormLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandFormLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // tableContainerFormLogin
            // 
            this.tableContainerFormLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableContainerFormLogin.ColumnCount = 1;
            this.tableContainerFormLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableContainerFormLogin.Controls.Add(this.bodyFormLogin, 0, 0);
            this.tableContainerFormLogin.Location = new System.Drawing.Point(5, 5);
            this.tableContainerFormLogin.Margin = new System.Windows.Forms.Padding(0);
            this.tableContainerFormLogin.Name = "tableContainerFormLogin";
            this.tableContainerFormLogin.RowCount = 1;
            this.tableContainerFormLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableContainerFormLogin.Size = new System.Drawing.Size(1313, 717);
            this.tableContainerFormLogin.TabIndex = 0;
            // 
            // bodyFormLogin
            // 
            this.bodyFormLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bodyFormLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bodyFormLogin.Controls.Add(this.labelPassLogin);
            this.bodyFormLogin.Controls.Add(this.labelUserLogin);
            this.bodyFormLogin.Controls.Add(this.brandFormLogin);
            this.bodyFormLogin.Controls.Add(this.inputEmailLogin);
            this.bodyFormLogin.Controls.Add(this.inputPasswordLogin);
            this.bodyFormLogin.Controls.Add(this.btnLogin);
            this.bodyFormLogin.Location = new System.Drawing.Point(449, 123);
            this.bodyFormLogin.Margin = new System.Windows.Forms.Padding(0);
            this.bodyFormLogin.Name = "bodyFormLogin";
            this.bodyFormLogin.Size = new System.Drawing.Size(415, 471);
            this.bodyFormLogin.TabIndex = 0;
            // 
            // labelPassLogin
            // 
            this.labelPassLogin.AutoSize = true;
            this.labelPassLogin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelPassLogin.Location = new System.Drawing.Point(21, 258);
            this.labelPassLogin.Name = "labelPassLogin";
            this.labelPassLogin.Size = new System.Drawing.Size(54, 22);
            this.labelPassLogin.TabIndex = 5;
            this.labelPassLogin.Text = "Senha";
            this.labelPassLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelUserLogin.Location = new System.Drawing.Point(21, 167);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(67, 22);
            this.labelUserLogin.TabIndex = 4;
            this.labelUserLogin.Text = "Usuário";
            this.labelUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandFormLogin
            // 
            this.brandFormLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandFormLogin.Image = ((System.Drawing.Image)(resources.GetObject("brandFormLogin.Image")));
            this.brandFormLogin.Location = new System.Drawing.Point(153, 26);
            this.brandFormLogin.Name = "brandFormLogin";
            this.brandFormLogin.Size = new System.Drawing.Size(108, 94);
            this.brandFormLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.brandFormLogin.TabIndex = 3;
            this.brandFormLogin.TabStop = false;
            // 
            // inputEmailLogin
            // 
            this.inputEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputEmailLogin.Location = new System.Drawing.Point(25, 192);
            this.inputEmailLogin.Name = "inputEmailLogin";
            this.inputEmailLogin.Size = new System.Drawing.Size(362, 30);
            this.inputEmailLogin.TabIndex = 2;
            // 
            // inputPasswordLogin
            // 
            this.inputPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputPasswordLogin.Location = new System.Drawing.Point(25, 283);
            this.inputPasswordLogin.Name = "inputPasswordLogin";
            this.inputPasswordLogin.Size = new System.Drawing.Size(362, 30);
            this.inputPasswordLogin.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(25, 359);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(362, 72);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1319, 719);
            this.Controls.Add(this.tableContainerFormLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tableContainerFormLogin.ResumeLayout(false);
            this.bodyFormLogin.ResumeLayout(false);
            this.bodyFormLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandFormLogin)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try { 
                _connection = new MySqlConnection(PIM.Database.Connection.stringConnection);
                _connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _connection;

                string authenticateUser = $"SELECT * FROM `holerite_pim`.`funcionario` WHERE email = '{inputEmailLogin.Text}';";
                cmd.CommandText = authenticateUser;
                cmd.Prepare();
                MySqlDataReader rdr = cmd.ExecuteReader();

   
                if (rdr.Read())
                {

                    _connection.Close();

                    _connection.Open();
                    string authenticatePassword = $"SELECT * FROM `holerite_pim`.`funcionario` WHERE email = '{inputEmailLogin.Text}' AND senha = '{inputPasswordLogin.Text}';";
                    cmd.Prepare();
                    cmd.CommandText = authenticatePassword;

                    MySqlDataReader user = cmd.ExecuteReader();

                    if (user.Read())
                    {

                        int id = user.GetInt32(0);
                        int idPermition = user.GetInt32(1);
                        int idRole = user.GetInt32(2);
                        string name = user.GetString(3);
                        string email = user.GetString(4);
                        string phone = user.GetString(5);
                        string cpf = user.GetString(6);
                        string password = user.GetString(7);
                        string status = user.GetString(8);
/*
                        PIM.Database.User.id = id;
                        PIM.Database.User.idPermition = idPermition;
                        PIM.Database.User.name = name;
                        PIM.Database.User.email = email;
                        PIM.Database.User.phone = phone;
                        PIM.Database.User.cpf = cpf;
                        PIM.Database.User.password = password;
                        PIM.Database.User.status = status;*/

                        MessageBox.Show("Login feito com sucesso!");

                        PIM.Home home = new PIM.Home();

                        this.Hide();
                        home.Show();
                        

                    } else
                    {
                        MessageBox.Show("Senha incorreta!");
                    }

                } else
                {
                    MessageBox.Show("Usuário não encontrado!");

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
            finally { _connection.Close(); }
        }
    }
}
