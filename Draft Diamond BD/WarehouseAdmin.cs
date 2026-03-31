using Draft_Diamond_BD.DataBaseProducts;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Draft_Diamond_BD
{
    public partial class WarehouseAdmin : Form
    {
        private DataGridView dgvWarehouse;
        private string userLogin;
        public WarehouseAdmin(string login)
        {
            InitializeComponent();
            userLogin = Resources.LoginInMenu + login;
            labelLogin.Text = userLogin;
            CreateDataGridView();
            LoadProducts();
            весьСкладToolStripMenuItem.Click += (s, e) => LoadProducts();
            кольцоToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Ring);
            серьгиToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Earring);
            браслетToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Bracelet);
            кольеToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Necklace);
            брошьToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Brooch);
            exitToolStripMenuItemOutput.Click += Exit_Click;
            buttonHistoryShipment.Click += ButtonHistoryShipment_Click;
            addCardToolStripMenuItem.Click += AddCardToolStripMenuItem_Click;
            changeCardToolStripMenuItem.Click += ChangeCardToolStripMenuItem_Click;
            deleteCardToolStripMenuItem.Click += deleteCardToolStripMenuItem_Click;
            searchShipmentToolStripMenuItem.Click+= SearchShipmentToolStripMenuItem_Click;
        }
        private void CreateDataGridView()
        {
            dgvWarehouse = new DataGridView
            {
                Location = new System.Drawing.Point(10, 150),
                Size = new System.Drawing.Size(700, 250),
                Margin = new Padding(10,10,10,10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.DarkGray,
            };
            Controls.Add(dgvWarehouse);
        }
        private void FilterProducts(string category)
        {
            using (var db = new DBProducts())
            {
                var products = db.Products.Where(p => p.Name == category).ToList();
                dgvWarehouse.DataSource = products;
                SetupColumns();
            }
        }
        /// <summary>
        /// Метод для работы с базой данных 
        /// </summary>
        public void LoadProducts()
        {
            using (var db = new DBProducts())
            {
                var products = db.Products.ToList();
                dgvWarehouse.DataSource = products;
                SetupColumns();
            }
        }
        private void SetupColumns()
        {
            if (dgvWarehouse.Columns["Id"] != null)
                dgvWarehouse.Columns["Id"].HeaderText = "ID";

            if (dgvWarehouse.Columns["Name"] != null)
                dgvWarehouse.Columns["Name"].HeaderText = "Название";

            if (dgvWarehouse.Columns["Count"] != null)
                dgvWarehouse.Columns["Count"].HeaderText = "Количество";

            if (dgvWarehouse.Columns["Price"] != null)
                dgvWarehouse.Columns["Price"].HeaderText = "Цена";

            if (dgvWarehouse.Columns["Rest"] != null)
                dgvWarehouse.Columns["Rest"].HeaderText = "Остаток";
        }
        private void AddCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCardForm = new AddCard();
            if (addCardForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts(); 
            }
        }
        private void ButtonHistoryShipment_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryShipment(userLogin);
            historyForm.Show();
            Hide();
        }
        private void ChangeCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changeCardForm = new ChangeCard(dgvWarehouse);
            changeCardForm.Show();
        }
        private void deleteCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteCardDelete = new DeleteCard(dgvWarehouse);
            deleteCardDelete.Show();
        }
        private void SearchShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var findShipmentForm = new FindShipment();
            findShipmentForm.Show();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void InitializeComponent()
        {
            this.labelwarehouse = new System.Windows.Forms.Label();
            this.menuStripWarehouseProducts = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchShipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItemFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.весьСкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кольцоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серьгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.браслетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кольеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.брошьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItemOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonHistoryShipment = new System.Windows.Forms.Button();
            this.menuStripWarehouseProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelwarehouse
            // 
            this.labelwarehouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelwarehouse.AutoSize = true;
            this.labelwarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwarehouse.Location = new System.Drawing.Point(12, 75);
            this.labelwarehouse.Name = "labelwarehouse";
            this.labelwarehouse.Size = new System.Drawing.Size(115, 36);
            this.labelwarehouse.TabIndex = 0;
            this.labelwarehouse.Text = "Склад:";
            // 
            // menuStripWarehouseProducts
            // 
            this.menuStripWarehouseProducts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripWarehouseProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.searchtoolStripMenuItem,
            this.filterToolStripMenuItemFilter,
            this.exitToolStripMenuItemOutput});
            this.menuStripWarehouseProducts.Location = new System.Drawing.Point(0, 0);
            this.menuStripWarehouseProducts.Name = "menuStripWarehouseProducts";
            this.menuStripWarehouseProducts.Size = new System.Drawing.Size(732, 30);
            this.menuStripWarehouseProducts.TabIndex = 1;
            this.menuStripWarehouseProducts.Text = "Меню";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCardToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(90, 26);
            this.toolStripMenuItem3.Text = "Добавить";
            // 
            // addCardToolStripMenuItem
            // 
            this.addCardToolStripMenuItem.Name = "addCardToolStripMenuItem";
            this.addCardToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.addCardToolStripMenuItem.Text = "Карточку ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCardToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 26);
            this.toolStripMenuItem2.Text = "Изменить";
            // 
            // changeCardToolStripMenuItem
            // 
            this.changeCardToolStripMenuItem.Name = "changeCardToolStripMenuItem";
            this.changeCardToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.changeCardToolStripMenuItem.Text = "Карточку";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCardToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 26);
            this.toolStripMenuItem1.Text = "Удалить";
            // 
            // deleteCardToolStripMenuItem
            // 
            this.deleteCardToolStripMenuItem.Name = "deleteCardToolStripMenuItem";
            this.deleteCardToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.deleteCardToolStripMenuItem.Text = "Карточку";
            this.deleteCardToolStripMenuItem.Click += new System.EventHandler(this.deleteCardToolStripMenuItem_Click);
            // 
            // searchtoolStripMenuItem
            // 
            this.searchtoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchShipmentToolStripMenuItem,
            this.найтиToolStripMenuItem});
            this.searchtoolStripMenuItem.Name = "searchtoolStripMenuItem";
            this.searchtoolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.searchtoolStripMenuItem.Text = "Поиск";
            // 
            // searchShipmentToolStripMenuItem
            // 
            this.searchShipmentToolStripMenuItem.Name = "searchShipmentToolStripMenuItem";
            this.searchShipmentToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.searchShipmentToolStripMenuItem.Text = "Найти отгрузку ";
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.найтиToolStripMenuItem.Text = "Поиск карточки ";
            // 
            // filterToolStripMenuItemFilter
            // 
            this.filterToolStripMenuItemFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.весьСкладToolStripMenuItem,
            this.кольцоToolStripMenuItem,
            this.серьгиToolStripMenuItem,
            this.браслетToolStripMenuItem,
            this.кольеToolStripMenuItem,
            this.брошьToolStripMenuItem});
            this.filterToolStripMenuItemFilter.Name = "filterToolStripMenuItemFilter";
            this.filterToolStripMenuItemFilter.Size = new System.Drawing.Size(74, 26);
            this.filterToolStripMenuItemFilter.Text = "Фильтр";
            // 
            // весьСкладToolStripMenuItem
            // 
            this.весьСкладToolStripMenuItem.Name = "весьСкладToolStripMenuItem";
            this.весьСкладToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.весьСкладToolStripMenuItem.Text = "Весь склад";
            // 
            // кольцоToolStripMenuItem
            // 
            this.кольцоToolStripMenuItem.Name = "кольцоToolStripMenuItem";
            this.кольцоToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.кольцоToolStripMenuItem.Text = "Кольцо";
            // 
            // серьгиToolStripMenuItem
            // 
            this.серьгиToolStripMenuItem.Name = "серьгиToolStripMenuItem";
            this.серьгиToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.серьгиToolStripMenuItem.Text = "Серьги";
            // 
            // браслетToolStripMenuItem
            // 
            this.браслетToolStripMenuItem.Name = "браслетToolStripMenuItem";
            this.браслетToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.браслетToolStripMenuItem.Text = "Браслет";
            // 
            // кольеToolStripMenuItem
            // 
            this.кольеToolStripMenuItem.Name = "кольеToolStripMenuItem";
            this.кольеToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.кольеToolStripMenuItem.Text = "Колье";
            // 
            // брошьToolStripMenuItem
            // 
            this.брошьToolStripMenuItem.Name = "брошьToolStripMenuItem";
            this.брошьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.брошьToolStripMenuItem.Text = "Брошь";
            // 
            // exitToolStripMenuItemOutput
            // 
            this.exitToolStripMenuItemOutput.Name = "exitToolStripMenuItemOutput";
            this.exitToolStripMenuItemOutput.Size = new System.Drawing.Size(67, 26);
            this.exitToolStripMenuItemOutput.Text = "Выход";
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(643, 3);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(5);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Padding = new System.Windows.Forms.Padding(2);
            this.labelLogin.Size = new System.Drawing.Size(68, 29);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "label1";
            // 
            // buttonHistoryShipment
            // 
            this.buttonHistoryShipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHistoryShipment.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonHistoryShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHistoryShipment.Location = new System.Drawing.Point(423, 75);
            this.buttonHistoryShipment.Name = "buttonHistoryShipment";
            this.buttonHistoryShipment.Size = new System.Drawing.Size(284, 51);
            this.buttonHistoryShipment.TabIndex = 4;
            this.buttonHistoryShipment.Text = "История Отгрузок";
            this.buttonHistoryShipment.UseVisualStyleBackColor = false;
            // 
            // WarehouseAdmin
            // 
            this.ClientSize = new System.Drawing.Size(732, 422);
            this.Controls.Add(this.buttonHistoryShipment);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelwarehouse);
            this.Controls.Add(this.menuStripWarehouseProducts);
            this.MainMenuStrip = this.menuStripWarehouseProducts;
            this.Name = "WarehouseAdmin";
            this.Text = "WarehouseAdmin";
            this.menuStripWarehouseProducts.ResumeLayout(false);
            this.menuStripWarehouseProducts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
