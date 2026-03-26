namespace Draft_Diamond_BD
{
    partial class AddCategory
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
            this.labelAddCategory = new System.Windows.Forms.Label();
            this.labelNameCategory = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddCategory
            // 
            this.labelAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAddCategory.AutoSize = true;
            this.labelAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddCategory.Location = new System.Drawing.Point(194, 9);
            this.labelAddCategory.Name = "labelAddCategory";
            this.labelAddCategory.Size = new System.Drawing.Size(339, 36);
            this.labelAddCategory.TabIndex = 0;
            this.labelAddCategory.Text = "Добавить категорию";
            // 
            // labelNameCategory
            // 
            this.labelNameCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNameCategory.AutoSize = true;
            this.labelNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameCategory.Location = new System.Drawing.Point(117, 123);
            this.labelNameCategory.Name = "labelNameCategory";
            this.labelNameCategory.Size = new System.Drawing.Size(128, 29);
            this.labelNameCategory.TabIndex = 1;
            this.labelNameCategory.Text = "Название:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Location = new System.Drawing.Point(295, 123);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(301, 35);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(227, 354);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(263, 48);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNameCategory);
            this.Controls.Add(this.labelAddCategory);
            this.Name = "AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddCategory;
        private System.Windows.Forms.Label labelNameCategory;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
    }
}