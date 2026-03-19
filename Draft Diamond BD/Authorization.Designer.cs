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
            this.enter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.enter.Location = new System.Drawing.Point(264, 407);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(233, 47);
            this.enter.TabIndex = 0;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLogin.Location = new System.Drawing.Point(264, 167);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(233, 30);
            this.txtLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPassword.Location = new System.Drawing.Point(264, 215);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // autorizatoinWorker
            // 
            this.autorizatoinWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autorizatoinWorker.AutoSize = true;
            this.autorizatoinWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorizatoinWorker.Location = new System.Drawing.Point(258, 58);
            this.autorizatoinWorker.Name = "autorizatoinWorker";
            this.autorizatoinWorker.Size = new System.Drawing.Size(247, 32);
            this.autorizatoinWorker.TabIndex = 3;
            this.autorizatoinWorker.Text = "АВТОРИЗАЦИЯ ";
            // 
            // loginWorker
            // 
            this.loginWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginWorker.AutoSize = true;
            this.loginWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginWorker.Location = new System.Drawing.Point(179, 171);
            this.loginWorker.Name = "loginWorker";
            this.loginWorker.Size = new System.Drawing.Size(74, 25);
            this.loginWorker.TabIndex = 4;
            this.loginWorker.Text = "Логин:";
            // 
            // passwordWorker
            // 
            this.passwordWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordWorker.AutoSize = true;
            this.passwordWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordWorker.Location = new System.Drawing.Point(179, 215);
            this.passwordWorker.Name = "passwordWorker";
            this.passwordWorker.Size = new System.Drawing.Size(86, 25);
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
            this.ClientSize = new System.Drawing.Size(894, 493);
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
