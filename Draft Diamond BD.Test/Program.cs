using Draft_Diamond_BD.Products;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Draft_Diamond_BD.Tests
{
    class Program
    {
        static void Test_WithProducts()
        {
            Console.Write("Test 1. With products ");
            var form = new DatabaseProduct("");
            var list = new List<Product> { new Product(), new Product() };
            form.ShowSearchResult(list);
            var grid = GetGrid(form);
            if (grid != null && grid.Rows.Count == 2)
                Console.WriteLine("Pass");
            else
                Console.WriteLine("Fail");
        }
        static void Test_EmptyList()
        {
            Console.Write("Test 2. Empty list ");
            var form = new DatabaseProduct("");
            var list = new List<Product>();
            form.ShowSearchResult(list);
            var grid = GetGrid(form);
            if (grid != null && grid.Rows.Count == 0)
                Console.WriteLine("Pass");
            else
                Console.WriteLine("Fail");
        }
        static void Test_Null()
        {
            Console.Write("Test 3. Null ");
            var form = new DatabaseProduct("");
            try
            {
                form.ShowSearchResult(null);
                Console.WriteLine("Fail");
            }
            catch
            {
                Console.WriteLine("Pass");
            }
        }
        static void Test_Duplicates()
        {
            Console.Write("Test 4. Duplicate products ");

            var form = new DatabaseProduct("");
            var list = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "Ring" },
                new Product { Id = Guid.NewGuid(), Name = "Ring" }
            };
            form.ShowSearchResult(list);
            var grid = GetGrid(form);
            if (grid != null && grid.Rows.Count == 2)
                Console.WriteLine("Pass");
            else
                Console.WriteLine("Fail");
        }

        static void Test_EmptyFields()
        {
            Console.Write("Test 5. Product with empty fields ");
            var form = new DatabaseProduct("");
            var list = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "", Count = 0, Price = 0, Rest = 0 }
            };
            try
            {
                form.ShowSearchResult(list);
                var grid = GetGrid(form);

                if (grid != null && grid.Rows.Count == 1)
                    Console.WriteLine("Pass");
                else
                    Console.WriteLine("Fail");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fail " + ex.Message);
            }
        }
        static DataGridView GetGrid(Form form)
        {
            var field = form.GetType().GetField("dgvProducts",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);

            return field?.GetValue(form) as DataGridView;
        }
        static void Main()
        {
            Test_WithProducts();
            Test_EmptyList();
            Test_Null();
            Test_Duplicates();
            Test_EmptyFields();

        }
    }
}
