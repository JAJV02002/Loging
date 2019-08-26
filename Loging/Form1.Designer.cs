namespace Loging
{
    partial class HarvardDataBase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HarvardDataBase));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginBotton = new System.Windows.Forms.Button();
            this.ExitBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.DarkRed;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WelcomeLabel.Location = new System.Drawing.Point(194, 19);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(477, 38);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to Harvard Data Base";
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsLabel.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InstructionsLabel.Location = new System.Drawing.Point(24, 275);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(328, 19);
            this.InstructionsLabel.TabIndex = 1;
            this.InstructionsLabel.Text = "Please log in to your account";
            this.InstructionsLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Location = new System.Drawing.Point(25, 316);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(79, 14);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Location = new System.Drawing.Point(25, 361);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(79, 14);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(125, 316);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(164, 23);
            this.UsernameTxt.TabIndex = 4;
            this.UsernameTxt.TextChanged += new System.EventHandler(this.UsernameTxt_TextChanged);
            this.UsernameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTxt_KeyPress);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(125, 352);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(164, 23);
            this.PasswordTxt.TabIndex = 5;
            this.PasswordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTxt_KeyPress);
            // 
            // LoginBotton
            // 
            this.LoginBotton.BackColor = System.Drawing.Color.White;
            this.LoginBotton.ForeColor = System.Drawing.Color.Black;
            this.LoginBotton.Location = new System.Drawing.Point(247, 395);
            this.LoginBotton.Name = "LoginBotton";
            this.LoginBotton.Size = new System.Drawing.Size(89, 38);
            this.LoginBotton.TabIndex = 6;
            this.LoginBotton.Text = "Log in";
            this.LoginBotton.UseVisualStyleBackColor = false;
            this.LoginBotton.Click += new System.EventHandler(this.LoginBotton_Click);
            // 
            // ExitBotton
            // 
            this.ExitBotton.BackColor = System.Drawing.Color.White;
            this.ExitBotton.ForeColor = System.Drawing.Color.Black;
            this.ExitBotton.Location = new System.Drawing.Point(60, 395);
            this.ExitBotton.Name = "ExitBotton";
            this.ExitBotton.Size = new System.Drawing.Size(89, 38);
            this.ExitBotton.TabIndex = 7;
            this.ExitBotton.Text = "Exit";
            this.ExitBotton.UseVisualStyleBackColor = false;
            this.ExitBotton.Click += new System.EventHandler(this.ExitBotton_Click);
            // 
            // HarvardDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 470);
            this.Controls.Add(this.ExitBotton);
            this.Controls.Add(this.LoginBotton);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Font = new System.Drawing.Font("MingLiU-ExtB", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HarvardDataBase";
            this.Text = "Harvard Data Base";
            this.Load += new System.EventHandler(this.HarvardDataBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button LoginBotton;
        private System.Windows.Forms.Button ExitBotton;
    }
}

