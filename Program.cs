using System;
using System.Collections.Generic;

class Item
{
    private string barcode;
    private string name;
    private int quantity;

    public Item(string barcode, string name, int quantity)
    {
        this.barcode = barcode;
        this.name = name;
        this.quantity = quantity;
    }

    public void IncreaseQuantity(int amount)
    {
        if (amount >= 0)
            quantity += amount;
        else
            Console.WriteLine("Invalid quantity increase. Quantity must be non-negative.");
    }

    public void DecreaseQuantity(int amount)
    {
        if (amount >= 0)
        {
            if (quantity >= amount)
                quantity -= amount;
            else
                Console.WriteLine("Insufficient quantity. Cannot decrease more than the current quantity.");
        }
        else
            Console.WriteLine("Invalid quantity decrease. Quantity must be non-negative.");
    }

    public string GetBarcode()
    {
        return barcode;
    }

    public string GetName()
    {
        return name;
    }

    public int GetQuantity()
    {
        return quantity;
    }
}

class Inventory
{
    private static Inventory instance;
    private Dictionary<string, Item> items;
    private int maxCapacity;

    private Inventory(int maxCapacity)
    {
        this.maxCapacity = maxCapacity;
        items = new Dictionary<string, Item>();
    }

    public static Inventory GetInstance(int maxCapacity)
    {
        if (instance == null)
        {
            instance = new Inventory(maxCapacity);
        }
        return instance;
    }

    public bool AddItem(string barcode, string name, int quantity)
    {
        if (items.Count >= maxCapacity)
        {
            Console.WriteLine("Inventory is full. Cannot add more items.");
            return false;
        }

        if (items.ContainsKey(barcode))
        {
            items[barcode].IncreaseQuantity(quantity);
        }
        else
        {
            Item newItem = new Item(barcode, name, quantity);
            items.Add(barcode, newItem);
        }

        return true;
    }

    public bool RemoveItem(string barcode)
    {
        if (items.ContainsKey(barcode))
        {
            items.Remove(barcode);
            return true;
        }

        Console.WriteLine("Item not found in the inventory.");
        return false;
    }

    public void IncreaseQuantity(int amount, string barcode)
    {
        if (items.ContainsKey(barcode))
        {
            items[barcode].IncreaseQuantity(amount);
        }
        else
        {
            Console.WriteLine("Item not found in the inventory.");
        }
    }

    public void DecreaseQuantity(int amount, string barcode)
    {
        if (items.ContainsKey(barcode))
        {
            items[barcode].DecreaseQuantity(amount);
        }
        else
        {
            Console.WriteLine("Item not found in the inventory.");
        }
    }

    public void ViewInventory()
    {
        Console.WriteLine("Inventory Items:");
        foreach (var item in items.Values)
        {
            Console.WriteLine("Barcode: " + item.GetBarcode());
            Console.WriteLine("Name: " + item.GetName());
            Console.WriteLine("Quantity: " + item.GetQuantity());
            Console.WriteLine();
        }
    }

    public int GetItemsCount()
    {
        return items.Count;
    }

    public int GetTotalQuantity()
    {
        int totalQuantity = 0;
        foreach (var item in items.Values)
        {
            totalQuantity += item.GetQuantity();
        }
        return totalQuantity;
    }

    ~Inventory()
    {
        Console.WriteLine("Inventory has been destroyed.");
    }
}

class Printer
{
    public void PrintItem(Item item)
    {
        Console.WriteLine("Item Information:");
        Console.WriteLine("Name: " + item.GetName());
        Console.WriteLine("Barcode: " + item.GetBarcode());
        Console.WriteLine("Quantity: " + item.GetQuantity());
        Console.WriteLine();
    }

    public void PrintInventory(Inventory inventory)
    {
        Console.WriteLine("Inventory Information:");
        Console.WriteLine("Total Unique Items: " + inventory.GetItemsCount());
        Console.WriteLine("Total Number of Items: " + inventory.GetTotalQuantity());
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the maximum capacity of the inventory: ");
        int maxCapacity = int.Parse(Console.ReadLine());

        Inventory inventory = Inventory.GetInstance(maxCapacity);

        while (true)
        {
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Increase Quantity");
            Console.WriteLine("4. Decrease Quantity");
            Console.WriteLine("5. View Inventory");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the barcode: ");
                    string barcode = Console.ReadLine();
                    Console.Write("Enter the name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the quantity: ");
                    int quantity = int.Parse(Console.ReadLine());

                    inventory.AddItem(barcode, name, quantity);
                    Console.WriteLine();
                    break;

                case 2:
                    Console.Write("Enter the barcode of the item to remove: ");
                    string removeBarcode = Console.ReadLine();

                    inventory.RemoveItem(removeBarcode);
                    Console.WriteLine();
                    break;

                case 3:
                    Console.Write("Enter the barcode of the item to increase quantity: ");
                    string increaseBarcode = Console.ReadLine();
                    Console.Write("Enter the amount to increase: ");
                    int increaseAmount = int.Parse(Console.ReadLine());

                    inventory.IncreaseQuantity(increaseAmount, increaseBarcode);
                    Console.WriteLine();
                    break;

                case 4:
                    Console.Write("Enter the barcode of the item to decrease quantity: ");
                    string decreaseBarcode = Console.ReadLine();
                    Console.Write("Enter the amount to decrease: ");
                    int decreaseAmount = int.Parse(Console.ReadLine());

                    inventory.DecreaseQuantity(decreaseAmount, decreaseBarcode);
                    Console.WriteLine();
                    break;

                case 5:
                    inventory.ViewInventory();
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
