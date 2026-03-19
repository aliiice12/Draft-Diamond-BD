namespace Draft_Diamond_BD
{
    partial class Registration
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
            this.registrationWorker = new System.Windows.Forms.Label();
            this.nameWorker = new System.Windows.Forms.Label();
            this.surnameWorker = new System.Windows.Forms.Label();
            this.loginWorker = new System.Windows.Forms.Label();
            this.passwordWorker = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrationWorker
            // 
            this.registrationWorker.AutoSize = true;
            this.registrationWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationWorker.Location = new System.Drawing.Point(92, 9);
            this.registrationWorker.Name = "registrationWorker";
            this.registrationWorker.Size = new System.Drawing.Size(243, 32);
            this.registrationWorker.TabIndex = 0;
            this.registrationWorker.Text = "РЕГИСТРАЦИЯ ";
            // 
            // nameWorker
            // 
            this.nameWorker.AutoSize = true;
            this.nameWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameWorker.Location = new System.Drawing.Point(26, 82);
            this.nameWorker.Name = "nameWorker";
            this.nameWorker.Size = new System.Drawing.Size(51, 20);
            this.nameWorker.TabIndex = 1;
            this.nameWorker.Text = "Имя:";
            // 
            // surnameWorker
            // 
            this.surnameWorker.AutoSize = true;
            this.surnameWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameWorker.Location = new System.Drawing.Point(26, 131);
            this.surnameWorker.Name = "surnameWorker";
            this.surnameWorker.Size = new System.Drawing.Size(100, 20);
            this.surnameWorker.TabIndex = 2;
            this.surnameWorker.Text = "Фамилия:";
            // 
            // loginWorker
            // 
            this.loginWorker.AutoSize = true;
            this.loginWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginWorker.Location = new System.Drawing.Point(26, 180);
            this.loginWorker.Name = "loginWorker";
            this.loginWorker.Size = new System.Drawing.Size(70, 20);
            this.loginWorker.TabIndex = 3;
            this.loginWorker.Text = "Логин:";
            // 
            // passwordWorker
            // 
            this.passwordWorker.AutoSize = true;
            this.passwordWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordWorker.Location = new System.Drawing.Point(26, 228);
            this.passwordWorker.Name = "passwordWorker";
            this.passwordWorker.Size = new System.Drawing.Size(84, 20);
            this.passwordWorker.TabIndex = 4;
            this.passwordWorker.Text = "Пароль:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(143, 82);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(327, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(143, 131);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(326, 19);
            this.textBoxSurname.TabIndex = 6;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(144, 180);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(325, 19);
            this.textBoxLogin.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(143, 228);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(324, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(98, 297);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(312, 53);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Зарегистрироваться ";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.passwordWorker);
            this.Controls.Add(this.loginWorker);
            this.Controls.Add(this.surnameWorker);
            this.Controls.Add(this.nameWorker);
            this.Controls.Add(this.registrationWorker);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrationWorker;
        private System.Windows.Forms.Label nameWorker;
        private System.Windows.Forms.Label surnameWorker;
        private System.Windows.Forms.Label loginWorker;
        private System.Windows.Forms.Label passwordWorker;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonRegister;
    }
}