namespace Draft_Diamond_BD
{
    partial class FindShipment
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
            this.labelFindShipment = new System.Windows.Forms.Label();
            this.labelIDShipment = new System.Windows.Forms.Label();
            this.labelNameShipment = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFindShipment
            // 
            this.labelFindShipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFindShipment.AutoSize = true;
            this.labelFindShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFindShipment.Location = new System.Drawing.Point(238, 27);
            this.labelFindShipment.Name = "labelFindShipment";
            this.labelFindShipment.Size = new System.Drawing.Size(254, 36);
            this.labelFindShipment.TabIndex = 0;
            this.labelFindShipment.Text = "Найти отгрузку";
            this.labelFindShipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIDShipment
            // 
            this.labelIDShipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIDShipment.AutoSize = true;
            this.labelIDShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIDShipment.Location = new System.Drawing.Point(110, 110);
            this.labelIDShipment.Name = "labelIDShipment";
            this.labelIDShipment.Size = new System.Drawing.Size(148, 29);
            this.labelIDShipment.TabIndex = 1;
            this.labelIDShipment.Text = "ID отгрузки:";
            // 
            // labelNameShipment
            // 
            this.labelNameShipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNameShipment.AutoSize = true;
            this.labelNameShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameShipment.Location = new System.Drawing.Point(130, 182);
            this.labelNameShipment.Name = "labelNameShipment";
            this.labelNameShipment.Size = new System.Drawing.Size(128, 29);
            this.labelNameShipment.TabIndex = 2;
            this.labelNameShipment.Text = "Название:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(244, 339);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(210, 48);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxID.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxID.Location = new System.Drawing.Point(264, 110);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(250, 34);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Location = new System.Drawing.Point(264, 182);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 34);
            this.textBoxName.TabIndex = 5;
            // 
            // FindShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelNameShipment);
            this.Controls.Add(this.labelIDShipment);
            this.Controls.Add(this.labelFindShipment);
            this.Name = "FindShipment";
            this.Text = "FindShipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFindShipment;
        private System.Windows.Forms.Label labelIDShipment;
        private System.Windows.Forms.Label labelNameShipment;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
    }
}