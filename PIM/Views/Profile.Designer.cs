namespace PIM.Views
{
    partial class Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.Label();
            this.cpfValue = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.Label();
            this.phoneValue = new System.Windows.Forms.Label();
            this.roleValue = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.idValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cargo:";
            // 
            // nameValue
            // 
            this.nameValue.AutoSize = true;
            this.nameValue.Location = new System.Drawing.Point(244, 172);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(0, 20);
            this.nameValue.TabIndex = 5;
            // 
            // cpfValue
            // 
            this.cpfValue.AutoSize = true;
            this.cpfValue.Location = new System.Drawing.Point(222, 227);
            this.cpfValue.Name = "cpfValue";
            this.cpfValue.Size = new System.Drawing.Size(0, 20);
            this.cpfValue.TabIndex = 6;
            // 
            // emailValue
            // 
            this.emailValue.AutoSize = true;
            this.emailValue.Location = new System.Drawing.Point(243, 285);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(0, 20);
            this.emailValue.TabIndex = 7;
            // 
            // phoneValue
            // 
            this.phoneValue.AutoSize = true;
            this.phoneValue.Location = new System.Drawing.Point(263, 337);
            this.phoneValue.Name = "phoneValue";
            this.phoneValue.Size = new System.Drawing.Size(0, 20);
            this.phoneValue.TabIndex = 8;
            // 
            // roleValue
            // 
            this.roleValue.AutoSize = true;
            this.roleValue.Location = new System.Drawing.Point(237, 389);
            this.roleValue.Name = "roleValue";
            this.roleValue.Size = new System.Drawing.Size(0, 20);
            this.roleValue.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(155, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 30);
            this.label12.TabIndex = 11;
            this.label12.Text = "ID:";
            // 
            // idValue
            // 
            this.idValue.AutoSize = true;
            this.idValue.Location = new System.Drawing.Point(215, 131);
            this.idValue.Name = "idValue";
            this.idValue.Size = new System.Drawing.Size(0, 20);
            this.idValue.TabIndex = 12;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1352, 852);
            this.Controls.Add(this.idValue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.roleValue);
            this.Controls.Add(this.phoneValue);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.cpfValue);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameValue;
        private System.Windows.Forms.Label cpfValue;
        private System.Windows.Forms.Label emailValue;
        private System.Windows.Forms.Label phoneValue;
        private System.Windows.Forms.Label roleValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label idValue;
    }
}