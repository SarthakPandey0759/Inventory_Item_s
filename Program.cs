using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // Update the item's price with the new price.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (QuantityInStock >= quantitySold)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Not enough stock to sell the requested quantity.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"Item Name: {ItemName}, Item ID: {ItemId}, Price: {Price:C}, Quantity in Stock: {QuantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // 1. Print details of all items.
        Console.WriteLine("Initial details of items:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();

        // 2. After a few sales, print the updated information.
        Console.WriteLine("Selling 3 laptops and 5 smartphones...");
        item1.SellItem(7);
        item2.SellItem(9);
        Console.WriteLine("Updated details of items:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();

        // 3. Restock an item and print the most recent data.
        Console.WriteLine("Restocking 5 laptops and 10 smartphones...");
        item1.RestockItem(18);
        item2.RestockItem(8);
        Console.WriteLine("Updated details of items after restocking:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();

        // 4. Verify whether a product has been placed in stock before printing a message about it.
        Console.WriteLine("Checking stock status:");
        Console.WriteLine($"Laptop is in stock: {item1.IsInStock()}");
        Console.WriteLine($"Smartphone is in stock: {item2.IsInStock()}");
    }
}
