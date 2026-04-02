namespace Draft_Diamond_BD
{
    partial class SearchShipment
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
            this.SearchShipmentText = new System.Windows.Forms.Label();
            this.IdShipmentText = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchShipmentText
            // 
            this.SearchShipmentText.AutoSize = true;
            this.SearchShipmentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SearchShipmentText.Location = new System.Drawing.Point(302, 35);
            this.SearchShipmentText.Name = "SearchShipmentText";
            this.SearchShipmentText.Size = new System.Drawing.Size(206, 31);
            this.SearchShipmentText.TabIndex = 0;
            this.SearchShipmentText.Text = "Найти отгрузку";
            // 
            // IdShipmentText
            // 
            this.IdShipmentText.AutoSize = true;
            this.IdShipmentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.IdShipmentText.Location = new System.Drawing.Point(169, 114);
            this.IdShipmentText.Name = "IdShipmentText";
            this.IdShipmentText.Size = new System.Drawing.Size(133, 26);
            this.IdShipmentText.TabIndex = 1;
            this.IdShipmentText.Text = "ID отгрузки:";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLogin.Location = new System.Drawing.Point(324, 113);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(184, 34);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(324, 181);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 34);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Name.Location = new System.Drawing.Point(169, 189);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(133, 26);
            this.Name.TabIndex = 4;
            this.Name.Text = "ID отгрузки:";
            // 
            // SearchShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.IdShipmentText);
            this.Controls.Add(this.SearchShipmentText);
            this.Text = "SearchShipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchShipmentText;
        private System.Windows.Forms.Label IdShipmentText;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Name;
    }
}