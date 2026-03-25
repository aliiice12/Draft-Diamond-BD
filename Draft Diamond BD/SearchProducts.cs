using System;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class SearchProducts : Form
    {
        public SearchProducts()
        {
           InitializeComponent();
            buttonSearch.Click += ButtonSearch_Click;
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var searchText = textSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                var dbForm = new DatabaseProduct(searchText);
                dbForm.Show();
            }
            else
            {
                MessageBox.Show(Resources.EnterProductName);
            }
        }
        private void InitializeComponent()
        {
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labelNameProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(149, 18);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(266, 36);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Поиск карточки ";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(155, 315);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(233, 55);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.textSearch.Location = new System.Drawing.Point(155, 116);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(250, 42);
            this.textSearch.TabIndex = 2;
            this.textSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNameProduct
            // 
            this.labelNameProduct.AutoSize = true;
            this.labelNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameProduct.Location = new System.Drawing.Point(44, 123);
            this.labelNameProduct.Name = "labelNameProduct";
            this.labelNameProduct.Size = new System.Drawing.Size(105, 25);
            this.labelNameProduct.TabIndex = 3;
            this.labelNameProduct.Text = "Название:";
            // 
            // SearchProducts
            // 
            this.ClientSize = new System.Drawing.Size(605, 426);
            this.Controls.Add(this.labelNameProduct);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSearch);
            this.Name = "SearchProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
