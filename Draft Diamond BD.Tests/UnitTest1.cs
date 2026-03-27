using Draft_Diamond_BD.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Draft_Diamond_BD.Tests
{
    [TestClass]
    public class DatabaseProductTests
    {
        [TestMethod]
        public void ShowSearchResult_WithProducts_ShowsTwoRows()
        {
            var form = new DatabaseProduct("");
            var products = new List<Product>
            {
                new Product(),
                new Product()
            };
            form.ShowSearchResult(products);
            var grid = GetDataGridView(form);
            Assert.IsNotNull(grid, "DataGridView not found");
            Assert.AreEqual(2, grid.Rows.Count, "Expected 2 rows");
        }

        [TestMethod]
        public void ShowSearchResult_EmptyList_ShowsZeroRows()
        {
            var form = new DatabaseProduct("");
            var products = new List<Product>();
            form.ShowSearchResult(products);
            var grid = GetDataGridView(form);
            Assert.IsNotNull(grid);
            Assert.AreEqual(0, grid.Rows.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShowSearchResult_Null_ThrowsException()
        {
            var form = new DatabaseProduct("");
            form.ShowSearchResult(null);
        }

        [TestMethod]
        public void ShowSearchResult_DuplicateProducts_ShowsBoth()
        {
            var form = new DatabaseProduct("");
            var products = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "Ring" },
                new Product { Id = Guid.NewGuid(), Name = "Ring" }
            };
            form.ShowSearchResult(products);
            var grid = GetDataGridView(form);
            Assert.IsNotNull(grid);
            Assert.AreEqual(2, grid.Rows.Count);
        }

        [TestMethod]
        public void ShowSearchResult_ProductWithEmptyFields_ShowsProduct()
        {
            var form = new DatabaseProduct("");
            var products = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "", Count = 0, Price = 0, Rest = 0 }
            };
            form.ShowSearchResult(products);
            var grid = GetDataGridView(form);
            Assert.IsNotNull(grid);
            Assert.AreEqual(1, grid.Rows.Count);
        }

        //Рефлексия для доступа к привату
        private DataGridView GetDataGridView(Form form)
        {
            var field = form.GetType().GetField("dgvProducts",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);

            return field?.GetValue(form) as DataGridView;
        }
    }
}