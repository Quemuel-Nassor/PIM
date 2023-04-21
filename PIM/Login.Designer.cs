using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PIM
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bodyFormLogin = new PIM.RoundedPanel();
            this.btnLogin = new RoudedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInputLoginPassword = new System.Windows.Forms.Label();
            this.labelInputLoginUser = new System.Windows.Forms.Label();
            this.inputLoginPassword = new System.Windows.Forms.TextBox();
            this.inputLoginUser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bodyFormLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1438, 689);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bodyFormLogin, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-405, -195);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.62963F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2246, 1076);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bodyFormLogin
            // 
            this.bodyFormLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bodyFormLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bodyFormLogin.BorderColor = System.Drawing.Color.Gray;
            this.bodyFormLogin.BorderThickness = 2;
            this.bodyFormLogin.Controls.Add(this.btnLogin);
            this.bodyFormLogin.Controls.Add(this.pictureBox1);
            this.bodyFormLogin.Controls.Add(this.labelInputLoginPassword);
            this.bodyFormLogin.Controls.Add(this.labelInputLoginUser);
            this.bodyFormLogin.Controls.Add(this.inputLoginPassword);
            this.bodyFormLogin.Controls.Add(this.inputLoginUser);
            this.bodyFormLogin.CornerRadius = 30;
            this.bodyFormLogin.Location = new System.Drawing.Point(901, 243);
            this.bodyFormLogin.Name = "bodyFormLogin";
            this.bodyFormLogin.Size = new System.Drawing.Size(444, 590);
            this.bodyFormLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(34, 436);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(380, 77);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelInputLoginPassword
            // 
            this.labelInputLoginPassword.AutoSize = true;
            this.labelInputLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelInputLoginPassword.Location = new System.Drawing.Point(29, 297);
            this.labelInputLoginPassword.Name = "labelInputLoginPassword";
            this.labelInputLoginPassword.Size = new System.Drawing.Size(70, 25);
            this.labelInputLoginPassword.TabIndex = 3;
            this.labelInputLoginPassword.Text = "Senha";
            // 
            // labelInputLoginUser
            // 
            this.labelInputLoginUser.AutoSize = true;
            this.labelInputLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelInputLoginUser.Location = new System.Drawing.Point(29, 181);
            this.labelInputLoginUser.Name = "labelInputLoginUser";
            this.labelInputLoginUser.Size = new System.Drawing.Size(79, 25);
            this.labelInputLoginUser.TabIndex = 2;
            this.labelInputLoginUser.Text = "Usuário";
            // 
            // inputLoginPassword
            // 
            this.inputLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputLoginPassword.Location = new System.Drawing.Point(34, 338);
            this.inputLoginPassword.Name = "inputLoginPassword";
            this.inputLoginPassword.Size = new System.Drawing.Size(380, 50);
            this.inputLoginPassword.TabIndex = 1;
            // 
            // inputLoginUser
            // 
            this.inputLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputLoginUser.Location = new System.Drawing.Point(34, 222);
            this.inputLoginUser.Name = "inputLoginUser";
            this.inputLoginUser.Size = new System.Drawing.Size(380, 30);
            this.inputLoginUser.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1438, 689);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bodyFormLogin.ResumeLayout(false);
            this.bodyFormLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedPanel bodyFormLogin;
        private System.Windows.Forms.TextBox inputLoginPassword;
        private System.Windows.Forms.TextBox inputLoginUser;
        private Label labelInputLoginPassword;
        private Label labelInputLoginUser;
        private PictureBox pictureBox1;
        private RoudedButton btnLogin;
    }
}

