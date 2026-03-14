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
                listProducts.DataSource = null;
                listProducts.DataSource = db.Shipments.ToList();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxTitle.Text;
            string unit = textBoxUnit.Text;
            string quantityText = textBoxQualitity.Text;
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
                    Quantity = quantity
                };

                db.Shipments.Add(shipment);
                db.SaveChanges();
            }

            LoadProducts();
            textBoxTitle.Clear();
            textBoxUnit.Clear();
            textBoxQualitity.Clear();
        }
        private void InitializeComponent()
        {
            listProducts = new DataGridView();
            shipment = new Label();
            list = new Label();
            title = new Label();
            unit = new Label();
            quantity = new Label();
            textBoxTitle = new TextBox();
            textBoxUnit = new TextBox();
            textBoxQualitity = new TextBox();
            buttonAdd = new Button();
            SuspendLayout();

            //DataGridView
            listProducts.Location = new System.Drawing.Point(350, 70);
            listProducts.Name = "listProducts";
            listProducts.Size = new System.Drawing.Size(400, 250);
            listProducts.TabIndex = 9;

            //Заголовок формы
            shipment.AutoSize = true;
            shipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            shipment.Location = new System.Drawing.Point(12, 9);
            shipment.Text = "Создать отгрузку";

            //Список
            list.AutoSize = true;
            list.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            list.Location = new System.Drawing.Point(350, 9);
            list.Text = "Список";

            //Название
            title.AutoSize = true;
            title.Location = new System.Drawing.Point(12, 70);
            title.Text = "Название:";

            //Ед измерения
            unit.AutoSize = true;
            unit.Location = new System.Drawing.Point(12, 110);
            unit.Text = "Ед. измерения:";

            //Количество
            quantity.AutoSize = true;
            quantity.Location = new System.Drawing.Point(12, 150);
            quantity.Text = "Количество:";

            //shipment

            shipment.AutoSize = true;
            shipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            shipment.Location = new System.Drawing.Point(9, 9);
            shipment.Name = "shipment";
            shipment.Size = new System.Drawing.Size(243, 32);
            shipment.TabIndex = 0;
            shipment.Text = "Создать отгрузку";

            //list

            list.AutoSize = true;
            list.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            list.Location = new System.Drawing.Point(404, 9);
            list.Name = "list";
            list.Size = new System.Drawing.Size(110, 32);
            list.TabIndex = 1;
            list.Text = "Список";

            //title


            title.AutoSize = true;
            title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title.Location = new System.Drawing.Point(12, 68);
            title.Name = "title";
            title.Size = new System.Drawing.Size(97, 22);
            title.TabIndex = 2;
            title.Text = "Название:";

            //unit

            unit.AutoSize = true;
            unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            unit.Location = new System.Drawing.Point(11, 110);
            unit.Name = "unit";
            unit.Size = new System.Drawing.Size(135, 22);
            unit.TabIndex = 3;
            unit.Text = "Ед.измерения:";

            //quantity

            quantity.AutoSize = true;
            quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            quantity.Location = new System.Drawing.Point(11, 154);
            quantity.Name = "quantity";
            quantity.Size = new System.Drawing.Size(114, 22);
            quantity.TabIndex = 4;
            quantity.Text = "Количество:";

            //textBoxTitle

            textBoxTitle.Location = new System.Drawing.Point(152, 70);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new System.Drawing.Size(170, 26);
            textBoxTitle.TabIndex = 5;

            //textBoxUnit

            textBoxUnit.Location = new System.Drawing.Point(152, 112);
            textBoxUnit.Multiline = true;
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.Size = new System.Drawing.Size(170, 23);
            textBoxUnit.TabIndex = 6;

            //textBoxQualitity

            textBoxQualitity.Location = new System.Drawing.Point(152, 156);
            textBoxQualitity.Multiline = true;
            textBoxQualitity.Name = "textBoxQualitity";
            textBoxQualitity.Size = new System.Drawing.Size(170, 26);
            textBoxQualitity.TabIndex = 7;

            //buttonAdd

            buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            buttonAdd.Location = new System.Drawing.Point(49, 204);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(232, 48);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;

            //CreatingShipment

            ClientSize = new System.Drawing.Size(800, 600);
            Controls.Add(listProducts);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxQualitity);
            Controls.Add(textBoxUnit);
            Controls.Add(textBoxTitle);
            Controls.Add(quantity);
            Controls.Add(unit);
            Controls.Add(title);
            Controls.Add(list);
            Controls.Add(shipment);
            Name = "CreatingShipment";
            PerformLayout();
        }
    }
}
