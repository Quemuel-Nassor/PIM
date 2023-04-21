using System;
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tableContainerFormLogin = new System.Windows.Forms.TableLayoutPanel();
            this.bodyFormLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.brandFormLogin = new System.Windows.Forms.PictureBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.labelPassLogin = new System.Windows.Forms.Label();
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
            this.bodyFormLogin.Controls.Add(this.textBox2);
            this.bodyFormLogin.Controls.Add(this.textBox1);
            this.bodyFormLogin.Controls.Add(this.btnLogin);
            this.bodyFormLogin.Location = new System.Drawing.Point(449, 123);
            this.bodyFormLogin.Margin = new System.Windows.Forms.Padding(0);
            this.bodyFormLogin.Name = "bodyFormLogin";
            this.bodyFormLogin.Size = new System.Drawing.Size(415, 471);
            this.bodyFormLogin.TabIndex = 0;
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
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(25, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(362, 30);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // brandFormLogin
            // 
            this.brandFormLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandFormLogin.Image = ((System.Drawing.Image)(resources.GetObject("brandFormLogin.Image")));
            this.brandFormLogin.Location = new System.Drawing.Point(153, 26);
            this.brandFormLogin.Name = "brandFormLogin";
            this.brandFormLogin.Size = new System.Drawing.Size(135, 118);
            this.brandFormLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.brandFormLogin.TabIndex = 3;
            this.brandFormLogin.TabStop = false;
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
            // labelPassLogin
            // 
            this.labelPassLogin.AutoSize = true;
            this.labelPassLogin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelPassLogin.Location = new System.Drawing.Point(21, 258);
            this.labelPassLogin.Name = "labelPassLogin";
            this.labelPassLogin.Size = new System.Drawing.Size(68, 28);
            this.labelPassLogin.TabIndex = 5;
            this.labelPassLogin.Text = "Senha";
            this.labelPassLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1319, 719);
            this.Controls.Add(this.tableContainerFormLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tableContainerFormLogin.ResumeLayout(false);
            this.bodyFormLogin.ResumeLayout(false);
            this.bodyFormLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandFormLogin)).EndInit();
            this.ResumeLayout(false);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
