using System;
using System.Collections.Generic;


// ----------------- Item -----------------
class Item
{
    public int ID {get; set;}
    public string Name {get; set;}
}

// ----------------- Database Singleton -----------------
class Database
{

    private static readonly Database _myInstance= new Database();
    private readonly  List<Item> _items ;

    // Private constructor prevents external instantiation
    private Database()
    {

     _items= new List<Item>();

    }
    // Public accessor + static 
    public static Database getInstance()
    {
        return _myInstance;
    }
    // Add item to the database
    public void AddItem(Item item)
    {

        _items.Add(item);
    }
    // Retrieve items
    public IEnumerable<Item> GetItems()
    {
        return _items;
    }
}

// ----------------- Client -----------------
class Client
{
    private Database _database;
    public Client()
    {
        // Get the singleton instance
        _database= Database.getInstance();
    }

    public void AddNewItem(int id, string name)
    {
        var item = new Item { ID = id, Name = name };
        _database.AddItem(item);
    }

    public void ShowItems()
    {
        foreach (var item in _database.GetItems())
        {
            Console.WriteLine($"ID: {item.ID}, Name: {item.Name}");
        }
    }
    
}
// ----------------- Example Usage -----------------
class Program
{
    static void Main()
    {
        Client client1 = new Client();
        Client client2 = new Client();

        client1.AddNewItem(1, "T-shirt");
        client2.AddNewItem(2, "Iphone");

        // Both clients share the same Database instance
        client1.ShowItems();
    }
}
