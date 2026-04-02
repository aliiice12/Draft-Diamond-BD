namespace Draft_Diamond_BD
{
    partial class Authorization
    {
        
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;

        private void InitializeComponent()
        {
            this.enter = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.autorizatoinWorker = new System.Windows.Forms.Label();
            this.loginWorker = new System.Windows.Forms.Label();
            this.passwordWorker = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(236, 320);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(192, 49);
            this.enter.TabIndex = 0;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLogin.Location = new System.Drawing.Point(254, 131);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(184, 34);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(254, 192);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(184, 36);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autorizatoinWorker
            // 
            this.autorizatoinWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autorizatoinWorker.AutoSize = true;
            this.autorizatoinWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorizatoinWorker.Location = new System.Drawing.Point(241, 63);
            this.autorizatoinWorker.Name = "autorizatoinWorker";
            this.autorizatoinWorker.Size = new System.Drawing.Size(197, 26);
            this.autorizatoinWorker.TabIndex = 3;
            this.autorizatoinWorker.Text = "АВТОРИЗАЦИЯ ";
            // 
            // loginWorker
            // 
            this.loginWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginWorker.AutoSize = true;
            this.loginWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginWorker.Location = new System.Drawing.Point(154, 134);
            this.loginWorker.Name = "loginWorker";
            this.loginWorker.Size = new System.Drawing.Size(69, 24);
            this.loginWorker.TabIndex = 4;
            this.loginWorker.Text = "Логин:";
            // 
            // passwordWorker
            // 
            this.passwordWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordWorker.AutoSize = true;
            this.passwordWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordWorker.Location = new System.Drawing.Point(142, 195);
            this.passwordWorker.Name = "passwordWorker";
            this.passwordWorker.Size = new System.Drawing.Size(81, 24);
            this.passwordWorker.TabIndex = 5;
            this.passwordWorker.Text = "Пароль:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(-2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(158, 29);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Зарегистрироваться ";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // Authorization
            // 
            this.ClientSize = new System.Drawing.Size(662, 461);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.passwordWorker);
            this.Controls.Add(this.loginWorker);
            this.Controls.Add(this.autorizatoinWorker);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPassword);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label autorizatoinWorker;
        private System.Windows.Forms.Label loginWorker;
        private System.Windows.Forms.Label passwordWorker;
        private System.Windows.Forms.Button btnRegister;
    }
}