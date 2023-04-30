namespace PIM.Views
{
    partial class Settings
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
            this.selectTheme = new System.Windows.Forms.ComboBox();
            this.labelTema = new System.Windows.Forms.Label();
            this.btnApplySettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configurações";
            // 
            // selectTheme
            // 
            this.selectTheme.FormattingEnabled = true;
            this.selectTheme.Items.AddRange(new object[] {
            "Escuro",
            "Claro"});
            this.selectTheme.Location = new System.Drawing.Point(143, 243);
            this.selectTheme.Name = "selectTheme";
            this.selectTheme.Size = new System.Drawing.Size(329, 24);
            this.selectTheme.TabIndex = 4;
            this.selectTheme.SelectedIndexChanged += new System.EventHandler(this.selectTheme_SelectedIndexChanged);
            // 
            // labelTema
            // 
            this.labelTema.AutoSize = true;
            this.labelTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTema.Location = new System.Drawing.Point(139, 209);
            this.labelTema.Name = "labelTema";
            this.labelTema.Size = new System.Drawing.Size(56, 22);
            this.labelTema.TabIndex = 5;
            this.labelTema.Text = "Tema";
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.Location = new System.Drawing.Point(1005, 694);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(231, 77);
            this.btnApplySettings.TabIndex = 6;
            this.btnApplySettings.Text = "Aplicar";
            this.btnApplySettings.UseVisualStyleBackColor = true;
            this.btnApplySettings.Click += new System.EventHandler(this.btnApplySettings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1352, 852);
            this.Controls.Add(this.btnApplySettings);
            this.Controls.Add(this.labelTema);
            this.Controls.Add(this.selectTheme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectTheme;
        private System.Windows.Forms.Label labelTema;
        private System.Windows.Forms.Button btnApplySettings;
    }
}