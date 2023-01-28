namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArg = input.Split();
                string serialNumber = cmdArg[0];
                string itemName = cmdArg[1];
                int itemQuantity = int.Parse(cmdArg[2]);
                decimal itemPrice = decimal.Parse(cmdArg[3]);

                Item item = new Item(itemName,itemPrice);
                Box box = new Box(serialNumber, itemQuantity,item);

                boxes.Add(box);

            }
            foreach (Box box in boxes.OrderByDescending( x => x.PricePerBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }
        }

    }
    public class Item
    {
        public Item(string itemName, decimal itemPrice)
        {
            Name = itemName;
            Price = itemPrice;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {

        public Box(string serialNumber, int itemQuantity, Item item)
        {
            SerialNumber = serialNumber;
            ItemQuantity = itemQuantity;
            Item = item;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PricePerBox
        {
            get
            {
                return Item.Price * ItemQuantity;
            }
            set
            {

            }
        }

    }
}