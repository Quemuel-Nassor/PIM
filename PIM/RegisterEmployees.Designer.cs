namespace PIM
{
    partial class RegisterEmployees
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
            this.containerRegisterEmployees = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectPermition = new System.Windows.Forms.ComboBox();
            this.selectOffice = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelOfiice = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.inputCPF = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.containerRegisterEmployees.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerRegisterEmployees
            // 
            this.containerRegisterEmployees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.containerRegisterEmployees.ColumnCount = 1;
            this.containerRegisterEmployees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerRegisterEmployees.Controls.Add(this.panel1, 0, 0);
            this.containerRegisterEmployees.Location = new System.Drawing.Point(1, 1);
            this.containerRegisterEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.containerRegisterEmployees.Name = "containerRegisterEmployees";
            this.containerRegisterEmployees.RowCount = 1;
            this.containerRegisterEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerRegisterEmployees.Size = new System.Drawing.Size(1350, 850);
            this.containerRegisterEmployees.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.selectPermition);
            this.panel1.Controls.Add(this.selectOffice);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.labelOfiice);
            this.panel1.Controls.Add(this.inputPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputEmail);
            this.panel1.Controls.Add(this.inputPhone);
            this.panel1.Controls.Add(this.inputCPF);
            this.panel1.Controls.Add(this.inputName);
            this.panel1.Location = new System.Drawing.Point(391, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 644);
            this.panel1.TabIndex = 0;
            // 
            // selectPermition
            // 
            this.selectPermition.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.selectPermition.FormattingEnabled = true;
            this.selectPermition.Items.AddRange(new object[] {
            "Admin",
            "Usuario"});
            this.selectPermition.Location = new System.Drawing.Point(87, 430);
            this.selectPermition.Name = "selectPermition";
            this.selectPermition.Size = new System.Drawing.Size(185, 32);
            this.selectPermition.TabIndex = 21;
            this.selectPermition.SelectedIndexChanged += new System.EventHandler(this.selectPermition_SelectedIndexChanged);
            // 
            // selectOffice
            // 
            this.selectOffice.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.selectOffice.FormattingEnabled = true;
            this.selectOffice.Items.AddRange(new object[] {
            "Desenvolvedor",
            "Marketing",
            "Designer"});
            this.selectOffice.Location = new System.Drawing.Point(293, 338);
            this.selectOffice.Name = "selectOffice";
            this.selectOffice.Size = new System.Drawing.Size(185, 32);
            this.selectOffice.TabIndex = 20;
            this.selectOffice.SelectedIndexChanged += new System.EventHandler(this.selectOffice_SelectedIndexChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(87, 538);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 67);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Administrador";
            // 
            // labelOfiice
            // 
            this.labelOfiice.AutoSize = true;
            this.labelOfiice.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelOfiice.Location = new System.Drawing.Point(289, 305);
            this.labelOfiice.Name = "labelOfiice";
            this.labelOfiice.Size = new System.Drawing.Size(58, 24);
            this.labelOfiice.TabIndex = 11;
            this.labelOfiice.Text = "Cargo";
            // 
            // inputPassword
            // 
            this.inputPassword.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputPassword.Location = new System.Drawing.Point(87, 338);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(185, 32);
            this.inputPassword.TabIndex = 9;
            this.inputPassword.TextChanged += new System.EventHandler(this.inputPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // inputEmail
            // 
            this.inputEmail.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputEmail.Location = new System.Drawing.Point(87, 261);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(391, 32);
            this.inputEmail.TabIndex = 3;
            this.inputEmail.TextChanged += new System.EventHandler(this.inputEmail_TextChanged);
            // 
            // inputPhone
            // 
            this.inputPhone.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputPhone.Location = new System.Drawing.Point(87, 176);
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Size = new System.Drawing.Size(185, 32);
            this.inputPhone.TabIndex = 2;
            this.inputPhone.TextChanged += new System.EventHandler(this.inputPhone_TextChanged);
            // 
            // inputCPF
            // 
            this.inputCPF.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputCPF.Location = new System.Drawing.Point(298, 176);
            this.inputCPF.Name = "inputCPF";
            this.inputCPF.Size = new System.Drawing.Size(185, 32);
            this.inputCPF.TabIndex = 1;
            this.inputCPF.TextChanged += new System.EventHandler(this.inputCPF_TextChanged);
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputName.Location = new System.Drawing.Point(90, 93);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(393, 32);
            this.inputName.TabIndex = 0;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // RegisterEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1352, 852);
            this.Controls.Add(this.containerRegisterEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterEmployees";
            this.Text = "Cadastrar Funcionário";
            this.containerRegisterEmployees.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel containerRegisterEmployees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.TextBox inputPhone;
        private System.Windows.Forms.TextBox inputCPF;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOfiice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox selectPermition;
        private System.Windows.Forms.ComboBox selectOffice;
    }
}