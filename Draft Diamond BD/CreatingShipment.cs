using Draft_Diamond_BD.DataBase;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class CreatingShipment : Form
    {
        private DataGridView listProducts;
        public CreatingShipment()
        {
            InitializeComponent();
            LoadProducts();
            buttonAdd.Click += new EventHandler(buttonAdd_Click);
        }
        private void LoadProducts()
        {
            using (DBShipment db = new DBShipment())
            {
                listProducts.AutoGenerateColumns = true;
                listProducts.DataSource = db.Shipments.ToList();

                listProducts.Columns["Id"].HeaderText = "ID";
                listProducts.Columns["Name"].HeaderText = "Название";
                listProducts.Columns["Unit"].HeaderText = "Ед.изм.";
                listProducts.Columns["Quantity"].HeaderText = "Количество";
                listProducts.Columns["Destination"].HeaderText = "Куда";
                listProducts.Columns["Recipient"].HeaderText = "Кому";
                
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxTitle.Text;
            string unit = textBoxUnit.Text;
            string quantityText = textBoxQualitity.Text;
            string destination = textBoxWhere.Text;
            string recipient = textBoxWhome.Text;
            int quantity;
            if (string.IsNullOrWhiteSpace(name) || //проверка поля нэйм
                string.IsNullOrWhiteSpace(unit) ||
                !int.TryParse(quantityText, out quantity))
            {
                MessageBox.Show("Введите корректные данные!");
                return;
            }

            using (DBShipment db = new DBShipment())
            {
                DBShipmentClass shipment = new DBShipmentClass
                {
                    Name = name,
                    Unit = unit,
                    Quantity = quantity,
                    Destination = destination,
                    Recipient = recipient
                };

                db.Shipments.Add(shipment);
                db.SaveChanges();
            }

            LoadProducts();
            textBoxTitle.Clear();
            textBoxUnit.Clear();
            textBoxQualitity.Clear();
            textBoxWhere.Clear();
            textBoxWhome.Clear();
        }
        private void InitializeComponent()
        {
            this.listProducts = new System.Windows.Forms.DataGridView();
            this.shipment = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.textBoxQualitity = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Whome = new System.Windows.Forms.Label();
            this.Where = new System.Windows.Forms.Label();
            this.textBoxWhome = new System.Windows.Forms.TextBox();
            this.textBoxWhere = new System.Windows.Forms.TextBox();
            this.buttonShipment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // listProducts
            // 
            this.listProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listProducts.ColumnHeadersHeight = 29;
            this.listProducts.Location = new System.Drawing.Point(419, 68);
            this.listProducts.Name = "listProducts";
            this.listProducts.RowHeadersWidth = 51;
            this.listProducts.Size = new System.Drawing.Size(425, 329);
            this.listProducts.TabIndex = 9;
            // 
            // shipment
            // 
            this.shipment.AutoSize = true;
            this.shipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shipment.Location = new System.Drawing.Point(9, 9);
            this.shipment.Name = "shipment";
            this.shipment.Size = new System.Drawing.Size(243, 32);
            this.shipment.TabIndex = 0;
            this.shipment.Text = "Создать отгрузку";
            // 
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.list.AutoSize = true;
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.Location = new System.Drawing.Point(413, 9);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(110, 32);
            this.list.TabIndex = 1;
            this.list.Text = "Список";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(12, 68);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(97, 22);
            this.title.TabIndex = 2;
            this.title.Text = "Название:";
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unit.Location = new System.Drawing.Point(11, 110);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(135, 22);
            this.unit.TabIndex = 3;
            this.unit.Text = "Ед.измерения:";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantity.Location = new System.Drawing.Point(11, 154);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(114, 22);
            this.quantity.TabIndex = 4;
            this.quantity.Text = "Количество:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxTitle.Location = new System.Drawing.Point(152, 70);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(170, 26);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxUnit.Location = new System.Drawing.Point(152, 110);
            this.textBoxUnit.Multiline = true;
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(170, 25);
            this.textBoxUnit.TabIndex = 6;
            // 
            // textBoxQualitity
            // 
            this.textBoxQualitity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxQualitity.Location = new System.Drawing.Point(152, 154);
            this.textBoxQualitity.Multiline = true;
            this.textBoxQualitity.Name = "textBoxQualitity";
            this.textBoxQualitity.Size = new System.Drawing.Size(170, 22);
            this.textBoxQualitity.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(50, 287);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(232, 48);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // Whome
            // 
            this.Whome.AutoSize = true;
            this.Whome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Whome.Location = new System.Drawing.Point(12, 194);
            this.Whome.Name = "Whome";
            this.Whome.Size = new System.Drawing.Size(59, 22);
            this.Whome.TabIndex = 10;
            this.Whome.Text = "Кому:";
            // 
            // Where
            // 
            this.Where.AutoSize = true;
            this.Where.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Where.Location = new System.Drawing.Point(13, 234);
            this.Where.Name = "Where";
            this.Where.Size = new System.Drawing.Size(57, 22);
            this.Where.TabIndex = 11;
            this.Where.Text = "Куда:";
            // 
            // textBoxWhome
            // 
            this.textBoxWhome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxWhome.Location = new System.Drawing.Point(152, 194);
            this.textBoxWhome.Name = "textBoxWhome";
            this.textBoxWhome.Size = new System.Drawing.Size(170, 22);
            this.textBoxWhome.TabIndex = 12;
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxWhere.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxWhere.Location = new System.Drawing.Point(152, 234);
            this.textBoxWhere.Multiline = true;
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(170, 22);
            this.textBoxWhere.TabIndex = 13;
            // 
            // buttonShipment
            // 
            this.buttonShipment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShipment.Location = new System.Drawing.Point(245, 431);
            this.buttonShipment.Name = "buttonShipment";
            this.buttonShipment.Size = new System.Drawing.Size(364, 72);
            this.buttonShipment.TabIndex = 14;
            this.buttonShipment.Text = "Отгрузить";
            this.buttonShipment.UseVisualStyleBackColor = false;
            // 
            // CreatingShipment
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(888, 565);
            this.Controls.Add(this.buttonShipment);
            this.Controls.Add(this.textBoxWhere);
            this.Controls.Add(this.textBoxWhome);
            this.Controls.Add(this.Where);
            this.Controls.Add(this.Whome);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxQualitity);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.title);
            this.Controls.Add(this.list);
            this.Controls.Add(this.shipment);
            this.Name = "CreatingShipment";
            ((System.ComponentModel.ISupportInitialize)(this.listProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
