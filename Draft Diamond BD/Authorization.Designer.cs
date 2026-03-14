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
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(73, 134);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(128, 47);
            this.enter.TabIndex = 0;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(100, 50);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(150, 22);
            this.txtLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // autorizatoinWorker
            // 
            this.autorizatoinWorker.AutoSize = true;
            this.autorizatoinWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorizatoinWorker.Location = new System.Drawing.Point(23, 9);
            this.autorizatoinWorker.Name = "autorizatoinWorker";
            this.autorizatoinWorker.Size = new System.Drawing.Size(247, 32);
            this.autorizatoinWorker.TabIndex = 3;
            this.autorizatoinWorker.Text = "АВТОРИЗАЦИЯ ";
            // 
            // loginWorker
            // 
            this.loginWorker.AutoSize = true;
            this.loginWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginWorker.Location = new System.Drawing.Point(12, 50);
            this.loginWorker.Name = "loginWorker";
            this.loginWorker.Size = new System.Drawing.Size(74, 25);
            this.loginWorker.TabIndex = 4;
            this.loginWorker.Text = "Логин:";
            // 
            // passwordWorker
            // 
            this.passwordWorker.AutoSize = true;
            this.passwordWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordWorker.Location = new System.Drawing.Point(8, 90);
            this.passwordWorker.Name = "passwordWorker";
            this.passwordWorker.Size = new System.Drawing.Size(86, 25);
            this.passwordWorker.TabIndex = 5;
            this.passwordWorker.Text = "Пароль:";
            // 
            // Authorization
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
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
    }
}