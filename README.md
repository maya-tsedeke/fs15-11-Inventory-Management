# Inventory Management
In this assignment, you will create a simple inventory management system which allows users to add, remove, and view items in the inventory.

## Requirements

Create class `Item`, which has barcode, name and quantity, which are private. Each item should have unique barcode, and quantity can not be negative. Provide the following methods:
1. Method `IncreaseQuantity` that takes an integer parameter, and increase the amount of item in the inventory.
2. Method `DecreaseQuantity` that takes an integer parameter, and decrease the amount of item in the inventory.
3. Methods to get name, quantity, barcode.

Create class `Inventory`, which can have only 1 instance, with the following properties and methods:
1. `items`: stores the inventory items and their quantity. Each item can only appear once in the inventory.
`maxCapacity`: stores the maximum total amount of items that can be stored in the inventory.
2. A constructor that takes an integer value as the maximum capacity of the inventory and initializes the items.
Use access modifiers to protect the `items` and `maxCapacity` property from direct external modifications.
3. Method `AddItem` that takes two string parameters (item and item quantity) and adds the item to the inventory. If the inventory reaches `maxCapacity`, the method should return false. Otherwise, it should add or replace the item in `items`.
4. Method `RemoveItem` that takes a string parameter (item barcode) and removes the item from the inventory. If the item does not exist in the inventory, the method should return false. Otherwise, it should remove the item from items and return true.
5. Method `IncreaseQuantity` that takes an integer parameter and a string parameter (item barcode), and increase the amount of item in the inventory.
6. Method `DecreaseQuantity` that takes an integer parameter and a string parameter (item barcode), and decrease the amount of item in the inventory.
7. Method called `ViewInventory` that prints the items (barcode, name, quantity) in the inventory to the console.
8. A destructor that prints a message to the console when the inventory is destroyed.

Create a class called "Printer" with 2 methods:
1. `PrintItem` takes 1 parameter of type `Item` and prints out information of a single item with name and barcode
2. `PrintInventory` takes 1 parameter of type `Inventory` and prints out information of the inventory with the amount of unique items and total number of items.

Use good naming convention and access modifier for class, properties, and methods.
Enter the maximum capacity of the inventory: 100
## Descriptions
The provided code implements a simple inventory management system in C#. The program consists of three classes: `Item`, `Inventory`, and `Printer`.

The `Item` class represents an item in the inventory. It has private fields for the barcode, name, and quantity. The class provides methods to increase and decrease the quantity, as well as getter methods for the barcode, name, and quantity.

The `Inventory` class is designed as a singleton, allowing only one instance of the inventory. It has private fields for a dictionary of items and the maximum capacity of the inventory. The class provides methods to add and remove items, increase and decrease the quantity of items, and view the inventory. The `GetInstance` method is used to obtain the singleton instance of the inventory.

The `Printer` class contains two methods: `PrintItem` and `PrintInventory`. The `PrintItem` method takes an `Item` object as a parameter and prints out information about the item. The `PrintInventory` method takes an `Inventory` object as a parameter and prints out information about the inventory, including the total number of unique items and the total number of items.

In the `Main` method of the `Program` class, an instance of the `Inventory` class is created with a maximum capacity of 100. Sample items are added to the inventory, and various operations such as increasing/decreasing quantity, removing items, and viewing the inventory are performed. Additionally, the `Printer` class is used to print out item and inventory information.

Overall, the code provides a basic implementation of an inventory management system, allowing users to interact with the inventory by adding, removing, and modifying items, as well as viewing the current state of the inventory.

## Sample Input and Output

        1. Add Item
        2. Remove Item
        3. Increase Quantity
        4. Decrease Quantity
        5. View Inventory
        6. Exit
        Enter your choice: 1

        Enter the barcode: 001
        Enter the name: Item 1
        Enter the quantity: 5

        1. Add Item
        2. Remove Item
        3. Increase Quantity
        4. Decrease Quantity
        5. View Inventory
        6. Exit
        Enter your choice: 1

        Enter the barcode: 002
        Enter the name: Item 2
        Enter the quantity: 10

        1. Add Item
        2. Remove Item
        3. Increase Quantity
        4. Decrease Quantity
        5. View Inventory
        6. Exit
        Enter your choice: 1

        Enter the barcode: 003
        Enter the name: Item 3
        Enter the quantity: 7

        1. Add Item
        2. Remove Item
        3. Increase Quantity
        4. Decrease Quantity
        5. View Inventory
        6. Exit
        Enter your choice: 5

        Inventory Items:
        Barcode: 001
        Name: Item 1
        Quantity: 5

        Barcode: 002
        Name: Item 2
        Quantity: 10

        Barcode: 003
        Name: Item 3
        Quantity: 7

        1. Add Item
        2. Remove Item
        3. Increase Quantity
        4. Decrease Quantity
        5. View Inventory
        6. Exit
        Enter your choice: 3

        Enter the barcode of the item to increase quantity: 002
        Enter the amount to increase: 3

        1. Add Item
        2. Remove Item
        3. Increase Quantity
        4. Decrease Quantity
        5. View Inventory
        6. Exit
        Enter your choice: 4

        Enter the barcode of the item to decrease quantity: 001
        Enter the amount to decrease: 2

        1. Add Item
        2. Remove Item
        3. Increase Quantity
        4. Decrease Quantity
        5. View Inventory
        6. Exit
        Enter your choice: 5

        Inventory Items:
        Barcode: 001
        Name: Item 1
        Quantity: 3

        Barcode: 002
        Name: Item 2
        Quantity: 13

        Barcode: 003
        Name: Item 3
        Quantity: 7

        1. Add Item
        2. Remove Item
        3. Increase Quantity
        4. Decrease Quantity
        5. View Inventory
        6. Exit
        Enter your choice: 2

        Enter the barcode of the item to remove: 003

        1. Add Item
        2. Remove Item
        3. Increase Quantity
        4. Decrease Quantity
        5. View Inventory
        6. Exit
        Enter your choice: 5

        Inventory Items:
        Barcode: 001
        Name: Item 1
        Quantity: 3

        Barcode: 002
        Name: Item 2
        Quantity: 13

        1. Add Item
        2. Remove Item
        3. Increase Quantity
        4. Decrease Quantity
        5. View Inventory
        6. Exit
        Enter your choice: 6

# NB:-
This example demonstrates adding three items to the inventory, viewing the inventory, increasing the quantity of an item, decreasing the quantity of another item, removing an item from the inventory, and finally viewing the updated inventory.