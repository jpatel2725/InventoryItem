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
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Not enough stock to sell.");
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
        Console.WriteLine($"Item Name: {ItemName}, Item ID: {ItemId}, Price: {Price}, Quantity In Stock: {QuantityInStock}");
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
        Console.WriteLine("Initial Inventory Details:");
        item1.PrintDetails();
        item2.PrintDetails();

        // 2. Sell some items and then print the updated details.
        item1.SellItem(5);
        item2.SellItem(10);
        Console.WriteLine("\nInventory Details After Selling Items:");
        item1.PrintDetails();
        item2.PrintDetails();

        // 3. Restock an item and print the updated details.
        item1.RestockItem(10);
        item2.RestockItem(20);
        Console.WriteLine("\nInventory Details After Restocking Items:");
        item1.PrintDetails();
        item2.PrintDetails();

        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine("\nStock Check:");
        Console.WriteLine($"{item1.ItemName} is {(item1.IsInStock() ? "in stock" : "out of stock")}.");
        Console.WriteLine($"{item2.ItemName} is {(item2.IsInStock() ? "in stock" : "out of stock")}.");
    }
}
