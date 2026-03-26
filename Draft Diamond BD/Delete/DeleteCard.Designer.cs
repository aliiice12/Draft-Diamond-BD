namespace Draft_Diamond_BD
{
    partial class DeleteCard
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
            this.labelDeleteCard = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeleteCard
            // 
            this.labelDeleteCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDeleteCard.AutoSize = true;
            this.labelDeleteCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeleteCard.Location = new System.Drawing.Point(221, 9);
            this.labelDeleteCard.Name = "labelDeleteCard";
            this.labelDeleteCard.Size = new System.Drawing.Size(303, 36);
            this.labelDeleteCard.TabIndex = 0;
            this.labelDeleteCard.Text = "Удалить карточку ";
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(111, 148);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(96, 25);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Артикул:";
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxId.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxId.Location = new System.Drawing.Point(236, 148);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(288, 36);
            this.textBoxId.TabIndex = 2;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(236, 320);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(251, 72);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // DeleteCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelDeleteCard);
            this.Name = "DeleteCard";
            this.Text = "DeleteCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeleteCard;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonDelete;
    }
}