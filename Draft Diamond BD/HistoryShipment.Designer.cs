namespace Draft_Diamond_BD
{
    partial class HistoryShipment
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
            this.labelHistoryShipment = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonListProduct = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHistoryShipment
            // 
            this.labelHistoryShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHistoryShipment.Location = new System.Drawing.Point(9, 78);
            this.labelHistoryShipment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHistoryShipment.Name = "labelHistoryShipment";
            this.labelHistoryShipment.Size = new System.Drawing.Size(140, 68);
            this.labelHistoryShipment.TabIndex = 0;
            this.labelHistoryShipment.Text = "История отгрузок:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.searchtoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // searchtoolStripMenuItem
            // 
            this.searchtoolStripMenuItem.Name = "searchtoolStripMenuItem";
            this.searchtoolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchtoolStripMenuItem.Text = "Поиск";
            // 
            // buttonListProduct
            // 
            this.buttonListProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonListProduct.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonListProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonListProduct.Location = new System.Drawing.Point(549, 92);
            this.buttonListProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonListProduct.Name = "buttonListProduct";
            this.buttonListProduct.Size = new System.Drawing.Size(172, 54);
            this.buttonListProduct.TabIndex = 2;
            this.buttonListProduct.Text = "Список товаров";
            this.buttonListProduct.UseVisualStyleBackColor = false;
            // 
            // HistoryShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.buttonListProduct);
            this.Controls.Add(this.labelHistoryShipment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HistoryShipment";
            this.Text = "HistoryShipment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHistoryShipment;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchtoolStripMenuItem;
        private System.Windows.Forms.Button buttonListProduct;
    }
}