namespace Draft_Diamond_BD
{
    partial class AddCard
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
            this.labelAddCard = new System.Windows.Forms.Label();
            this.labelNameCard = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddCard
            // 
            this.labelAddCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAddCard.AutoSize = true;
            this.labelAddCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddCard.Location = new System.Drawing.Point(206, 9);
            this.labelAddCard.Name = "labelAddCard";
            this.labelAddCard.Size = new System.Drawing.Size(313, 36);
            this.labelAddCard.TabIndex = 0;
            this.labelAddCard.Text = "Добавить карточку";
            // 
            // labelNameCard
            // 
            this.labelNameCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNameCard.AutoSize = true;
            this.labelNameCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameCard.Location = new System.Drawing.Point(118, 102);
            this.labelNameCard.Name = "labelNameCard";
            this.labelNameCard.Size = new System.Drawing.Size(128, 29);
            this.labelNameCard.TabIndex = 1;
            this.labelNameCard.Text = "Название:";
            this.labelNameCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnit
            // 
            this.labelUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnit.Location = new System.Drawing.Point(96, 149);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(161, 66);
            this.labelUnit.TabIndex = 2;
            this.labelUnit.Text = "   Единица измерения:";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(92, 226);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(165, 29);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "цена закупки:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Location = new System.Drawing.Point(263, 102);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(229, 29);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUnit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUnit.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxUnit.Location = new System.Drawing.Point(263, 156);
            this.textBoxUnit.Multiline = true;
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(229, 32);
            this.textBoxUnit.TabIndex = 5;
            this.textBoxUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPrice.Location = new System.Drawing.Point(263, 226);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(229, 29);
            this.textBoxPrice.TabIndex = 6;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(232, 341);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(252, 60);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.labelNameCard);
            this.Controls.Add(this.labelAddCard);
            this.Name = "AddCard";
            this.Text = "AddCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddCard;
        private System.Windows.Forms.Label labelNameCard;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAdd;
    }
}