namespace PIM
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRegisterEmployees = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.brandPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.containerMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelContentForm = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.brandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.containerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.mainPanel.Controls.Add(this.btnSettings);
            this.mainPanel.Controls.Add(this.btnLogout);
            this.mainPanel.Controls.Add(this.btnRegisterEmployees);
            this.mainPanel.Controls.Add(this.btnHome);
            this.mainPanel.Controls.Add(this.btnEmployees);
            this.mainPanel.Controls.Add(this.brandPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(436, 853);
            this.mainPanel.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(7, 398);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(426, 68);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "  Configurações";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(6, 472);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(426, 68);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "  Sair";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRegisterEmployees
            // 
            this.btnRegisterEmployees.FlatAppearance.BorderSize = 0;
            this.btnRegisterEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRegisterEmployees.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegisterEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterEmployees.Image")));
            this.btnRegisterEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterEmployees.Location = new System.Drawing.Point(6, 324);
            this.btnRegisterEmployees.Name = "btnRegisterEmployees";
            this.btnRegisterEmployees.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegisterEmployees.Size = new System.Drawing.Size(426, 68);
            this.btnRegisterEmployees.TabIndex = 6;
            this.btnRegisterEmployees.Text = "  Cadastrar Funcionários";
            this.btnRegisterEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterEmployees.UseVisualStyleBackColor = true;
            this.btnRegisterEmployees.Click += new System.EventHandler(this.btnRegisterEmployees_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(6, 176);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(426, 68);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(7, 250);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(426, 68);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "  Funcionários";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // brandPanel
            // 
            this.brandPanel.Controls.Add(this.pictureBox1);
            this.brandPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.brandPanel.Location = new System.Drawing.Point(0, 0);
            this.brandPanel.Name = "brandPanel";
            this.brandPanel.Size = new System.Drawing.Size(436, 142);
            this.brandPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // containerMain
            // 
            this.containerMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.containerMain.ColumnCount = 1;
            this.containerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerMain.Controls.Add(this.panelContentForm, 0, 0);
            this.containerMain.Location = new System.Drawing.Point(437, 1);
            this.containerMain.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.containerMain.Name = "containerMain";
            this.containerMain.RowCount = 1;
            this.containerMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerMain.Size = new System.Drawing.Size(1360, 851);
            this.containerMain.TabIndex = 1;
            // 
            // panelContentForm
            // 
            this.panelContentForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContentForm.Location = new System.Drawing.Point(5, 0);
            this.panelContentForm.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panelContentForm.Name = "panelContentForm";
            this.panelContentForm.Size = new System.Drawing.Size(1690, 1064);
            this.panelContentForm.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1795, 853);
            this.Controls.Add(this.containerMain);
            this.Controls.Add(this.mainPanel);
            this.Location = new System.Drawing.Point(50, 0);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.mainPanel.ResumeLayout(false);
            this.brandPanel.ResumeLayout(false);
            this.brandPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.containerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel brandPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRegisterEmployees;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TableLayoutPanel containerMain;
        private System.Windows.Forms.Panel panelContentForm;
    }
}