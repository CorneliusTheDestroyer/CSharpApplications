
List<string> shoppingList = new List<string>
{
    "apples",
    "bananas",
    "carrots",
    "doughnuts",
    "eggs"
};

string userInput;

while (shoppingList.Count != 0)
{
    Console.WriteLine("Current shopping list:");

    foreach (string item in shoppingList)
    {
        Console.WriteLine($"- {item}");
    }

    Console.Write("Enter an item to add to or remove from the shopping list (or type 'exit' to quit):");
    userInput = Console.ReadLine();
    
    if (userInput.ToLower() == "exit")
    {
        break;
    }
    else if (shoppingList.Contains(userInput.ToLower()))
        shoppingList.Remove(userInput.ToLower());
    else
        shoppingList.Add(userInput.ToLower());
    
    Console.Clear();
}

