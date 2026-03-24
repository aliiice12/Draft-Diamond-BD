using System;
namespace Draft_Diamond_BD.DataBase
{
    public class DBShipmentClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public string Destination { get; set; }
        public string Recipient { get; set; }
    }
}

