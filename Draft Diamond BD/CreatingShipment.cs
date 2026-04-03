using Draft_Diamond_BD.DataBase;
using Draft_Diamond_BD.DataBaseProducts;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Draft_Diamond_BD
{
    public partial class CreatingShipment : Form
    {
        private DataGridView listProducts;
        private string userLogin;
        public CreatingShipment(string login)
        {
            InitializeComponent();
            userLogin = login;
            if (listProducts == null)
            {
                listProducts = new DataGridView
                {
                    Location = new Point(20, 150),
                    Size = new Size(800, 400),
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                };
                Controls.Add(listProducts);
            }
            LoadProducts();
            buttonAdd.Click += new EventHandler(buttonAdd_Click);
            buttonShipment.Click += new EventHandler(buttonShipment_Click);
        }
        private void LoadProducts()
        {
            using (var db = new DBShipmentBasket())
            {
                listProducts.AutoGenerateColumns = true;
                listProducts.DataSource = db.Shipments.Select(p => new
                {p.Name, p.Unit, p.Quantity, p.Destination, p.Recipient}).ToList();
                CreateCollums();
                listProducts.DataBindingComplete -= ListProducts_DataBindingComplete;
                listProducts.DataBindingComplete += ListProducts_DataBindingComplete;
            }  
        }
        private void CreateCollums()
        {
            if (listProducts.Columns["Name"] != null)
                listProducts.Columns["Name"].HeaderText = "Название";
            if (listProducts.Columns["Unit"] != null)
                listProducts.Columns["Unit"].HeaderText = "Ед.изм.";
            if (listProducts.Columns["Quantity"] != null)
                listProducts.Columns["Quantity"].HeaderText = "Количество";
            if (listProducts.Columns["Destination"] != null)
                listProducts.Columns["Destination"].HeaderText = "Куда";
            if (listProducts.Columns["Recipient"] != null)
                listProducts.Columns["Recipient"].HeaderText = "Кому";
            if (!listProducts.Columns.Contains("Кто создал"))
            {
                var createdByColumn = new DataGridViewTextBoxColumn
                {
                    Name = "Кто создал",
                    HeaderText = "Кто создал",
                    ReadOnly = true,
                    DataPropertyName = null
                };
                listProducts.Columns.Add(createdByColumn);
            };
        }
        private void ListProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in listProducts.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["Кто создал"].Value = userLogin; 
            }
        }
        //вот здесь выпадающие списки надо реализовать 
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var name = textBoxTitle.Text.Trim();
            var unit = textBoxUnit.Text.Trim();
            var quantityText = textBoxQualitity.Text.Trim();
            var destination = textBoxWhere.Text.Trim();
            var recipient = textBoxWhome.Text.Trim();
            int quantity;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(unit) || !int.TryParse(quantityText, out quantity))
            {
                MessageBox.Show(Resources.EnterTheCorrectInformation);
                return;
            }
            using (var db = new DBShipmentBasket())
            using (var dbProducts = new DBProducts())
            {
                var product = dbProducts.Products.FirstOrDefault(p => p.Name == name);
                if (product == null)
                {
                    MessageBox.Show(Resources.NotDatabase);
                    return;
                }
                if (product.Rest < quantity)
                {
                    MessageBox.Show(Resources.NotEnough);
                    return;
                }
                var shipment = new DBShipmentClass
                {
                    Name = name,
                    Unit = unit,
                    Quantity = quantity,
                    Destination = destination,
                    Recipient = recipient,
                };
                db.Shipments.Add(shipment);
                product.Rest -= quantity;
                db.SaveChanges();
                dbProducts.SaveChanges();
            }

            LoadProducts();
            textBoxTitle.Clear();
            textBoxUnit.Clear();
            textBoxQualitity.Clear();
            textBoxWhere.Clear();
            textBoxWhome.Clear();
            MessageBox.Show(Resources.InformationSuccess, Resources.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void buttonShipment_Click(object sender, EventArgs e)
        {
            using (var dataSource = new DBShipmentBasket())
            {
                var allProductsInBasket = dataSource.Shipments.ToList();
                if (allProductsInBasket.Count == 0)
                {
                    MessageBox.Show("Нет данных");
                    return;
                }
                for (var i = 0; i < allProductsInBasket.Count; i++)
                {
                    using (var dataSource2 = new DBProducts())
                    {
                        var products = dataSource2.Products.FirstOrDefault(p => p.Id == allProductsInBasket[i].Id);
                        products.Count = products.Count - allProductsInBasket[i].Quantity;

                        dataSource2.SaveChanges();
                    }
                }
            }
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
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(25, 82);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(105, 25);
            this.title.TabIndex = 2;
            this.title.Text = "Название:";
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unit.Location = new System.Drawing.Point(10, 127);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(153, 25);
            this.unit.TabIndex = 3;
            this.unit.Text = "Ед.измерения:";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantity.Location = new System.Drawing.Point(12, 177);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(129, 25);
            this.quantity.TabIndex = 4;
            this.quantity.Text = "Количество:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxTitle.Location = new System.Drawing.Point(169, 76);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(170, 26);
            this.textBoxTitle.TabIndex = 5;
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUnit.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxUnit.Location = new System.Drawing.Point(169, 127);
            this.textBoxUnit.Multiline = true;
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(170, 25);
            this.textBoxUnit.TabIndex = 6;
            this.textBoxUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxQualitity
            // 
            this.textBoxQualitity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxQualitity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQualitity.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxQualitity.Location = new System.Drawing.Point(169, 177);
            this.textBoxQualitity.Multiline = true;
            this.textBoxQualitity.Name = "textBoxQualitity";
            this.textBoxQualitity.Size = new System.Drawing.Size(170, 25);
            this.textBoxQualitity.TabIndex = 7;
            this.textBoxQualitity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(55, 340);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(232, 48);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // Whome
            // 
            this.Whome.AutoSize = true;
            this.Whome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Whome.Location = new System.Drawing.Point(42, 224);
            this.Whome.Name = "Whome";
            this.Whome.Size = new System.Drawing.Size(67, 25);
            this.Whome.TabIndex = 10;
            this.Whome.Text = "Кому:";
            // 
            // Where
            // 
            this.Where.AutoSize = true;
            this.Where.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Where.Location = new System.Drawing.Point(42, 279);
            this.Where.Name = "Where";
            this.Where.Size = new System.Drawing.Size(61, 25);
            this.Where.TabIndex = 11;
            this.Where.Text = "Куда:";
            // 
            // textBoxWhome
            // 
            this.textBoxWhome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxWhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWhome.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxWhome.Location = new System.Drawing.Point(169, 224);
            this.textBoxWhome.Multiline = true;
            this.textBoxWhome.Name = "textBoxWhome";
            this.textBoxWhome.Size = new System.Drawing.Size(170, 25);
            this.textBoxWhome.TabIndex = 12;
            this.textBoxWhome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWhere.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxWhere.Location = new System.Drawing.Point(169, 275);
            this.textBoxWhere.Multiline = true;
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(170, 29);
            this.textBoxWhere.TabIndex = 13;
            this.textBoxWhere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonShipment
            // 
            this.buttonShipment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
