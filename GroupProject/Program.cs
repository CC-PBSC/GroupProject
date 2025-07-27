// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System.ComponentModel.Design;


class Program
{
    string optionNumber = "";
    Boolean exit = false;
    static Dictionary<string, string> dDict = new Dictionary<string, string>();
    static void Main()
    {
        Boolean exit = false;
        //loops until thingy is set to false
        while (exit == false)
        {
            Console.WriteLine("1. Add new key and value");
            Console.WriteLine("2. Add value to existing key");
            Console.WriteLine("3. Remove key");
            Console.WriteLine("4. Display contents");
            Console.WriteLine("5. Display sorted keys");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option between 1 and 6");
            string numChoice = Console.ReadLine();

            //calls a different function/method based on answer
            //instantly breaks
            switch (numChoice)
            {
                case "1":
                    AddNewKey();
                    break;
                case "2":
                    AddNewValueKey();
                    break;
                case "3":
                    RemoveKey();
                    break;
                case "4":
                    DisplayContents();
                    break;
                case "5":
                    DisplaySorted();
                    break;
                case "6":
                    exit = true;
                    break;

            }
            //exit of while loop

            //adds a new key, checks first to see if it exists before allowing a value
            static void AddNewKey()
            {
                Console.Write("Enter a key");
                String key = Console.ReadLine();


                if (dDict.ContainsKey(key))
                {
                    Console.WriteLine("Key already exists. Enter a new one");
                }
                Console.WriteLine("Now enter a value"); ;
                String value = Console.ReadLine();
                dDict[key] = value;
            }

            //add a new value to the key, if it does, it allows the user to enter an ew one
            // it finds the key and changes the value
            static void AddNewValueKey()
            {
                Console.WriteLine("What key do you want to change?");
                String key = Console.ReadLine();
                if(dDict.ContainsKey(key))
                {
                    Console.WriteLine("Enter a value");
                    String value = Console.ReadLine();
                    dDict[key] = value;

                }
                else 
                    Console.WriteLine("Key not found.");

                
            }

            // checks to see if the key even exists before it removes it
            //else it tells the user it wasnt found
            static void RemoveKey()
            {
                Console.WriteLine("Enter key name to remove");
                String key = Console.ReadLine();
                if (dDict.ContainsKey(key))
                {
                    dDict.Remove(key);
                }
                else
                {
                    Console.WriteLine("Key not found");
                }
            }

            //displays contents using a foreach loop
            static void DisplayContents()
            {
                if (dDict.Count == 0)
                {
                    Console.WriteLine("Dictionary is empty");
                }

                else
                {
                    foreach (var item in dDict)
                    {
                        Console.WriteLine("Key " + item.Key + " Value " + item.Value);
                    }
                }
            }

            //i got lost how to manipulate dictionaries
            //will work on later, prob will finish b4 due date
            static void DisplaySorted()
            {
                if (dDict.Count == 0)
                {
                    Console.WriteLine("Dictionary is empty");
                }
                foreach (var key in dDict.Keys.OrderBy(k => k))
                {
                    Console.WriteLine($"{key}: {dDict[key]}");
                }

            }


        }
    }
}