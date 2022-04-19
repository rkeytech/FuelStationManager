namespace FuelStation.Win
{
    partial class LoginF
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
            this.lblUserUsername = new System.Windows.Forms.Label();
            this.ctrlUsername = new System.Windows.Forms.TextBox();
            this.ctrlPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserUsername
            // 
            this.lblUserUsername.AutoSize = true;
            this.lblUserUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblUserUsername.Location = new System.Drawing.Point(44, 96);
            this.lblUserUsername.Name = "lblUserUsername";
            this.lblUserUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUserUsername.TabIndex = 0;
            this.lblUserUsername.Text = "Username";
            // 
            // ctrlUsername
            // 
            this.ctrlUsername.Location = new System.Drawing.Point(140, 93);
            this.ctrlUsername.Name = "ctrlUsername";
            this.ctrlUsername.Size = new System.Drawing.Size(201, 23);
            this.ctrlUsername.TabIndex = 1;
            // 
            // ctrlPassword
            // 
            this.ctrlPassword.Location = new System.Drawing.Point(140, 134);
            this.ctrlPassword.Name = "ctrlPassword";
            this.ctrlPassword.PasswordChar = '*';
            this.ctrlPassword.Size = new System.Drawing.Size(201, 23);
            this.ctrlPassword.TabIndex = 3;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lblUserPassword.Location = new System.Drawing.Point(44, 137);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(57, 15);
            this.lblUserPassword.TabIndex = 2;
            this.lblUserPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(125, 202);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.ctrlPassword);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.ctrlUsername);
            this.Controls.Add(this.lblUserUsername);
            this.Name = "LoginF";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUserUsername;
        private TextBox ctrlUsername;
        private TextBox ctrlPassword;
        private Label lblUserPassword;
        private Button btnLogin;
    }
}