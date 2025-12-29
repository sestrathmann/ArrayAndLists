// See https://aka.ms/new-console-template for more information
//Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

//Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

//Add in a message that displays when the user selects an index that doesn’t exist.

//Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.

//STRING ARRAY
//Initialize array of strings
string[] planets = new string[] {"Mercury", "Venus", "Earth", "Mars", "Jupiter"};
//Prompt user for index
Console.WriteLine("Enter an index number between 0 and 4 to display a planet:");
//Get user input and convert to integer
int planetIndex = Convert.ToInt32(Console.ReadLine());
//Check if user input index is less than the length of the array minus 1, display error message if not, display planet if valid
if (planetIndex > planets.Length - 1)
{     Console.WriteLine("The index you selected does not exist. Please run the program again and select a valid index.");
    return;
}else
    Console.WriteLine("Here is the planet at index " + planetIndex + ": " + planets[planetIndex]);


//INTEGER ARRAY
//Initialize array of integers
int[] numbers = new int[] {16,11,72,99,31};
Console.WriteLine("Enter an index number between 0 and 4 to display a number:");
//Prompt user for index
int chosenIndex = Convert.ToInt32(Console.ReadLine());
//Check if user input index is less than the length of the array minus 1, display error message if not, display number if valid
if (chosenIndex > numbers.Length - 1)
{
    Console.WriteLine("The index you selected does not exist. Please run the program again and select a valid index.");
    return;
}
else
    Console.WriteLine("Here is the number at index " + chosenIndex + ": " + numbers[chosenIndex]);


//LIST OF STRINGS
//Initialize list of strings
List<string> usStates = new List<string> { "California", "Texas", "Florida", "New York", "Illinois" };
//Prompt user for index
Console.WriteLine("Enter an index number between 0 and 4 to display a US state:");
//Get user input and convert to integer
int stateIndex = Convert.ToInt32(Console.ReadLine());
//Check if user input index is less than the length of the list minus 1, display error message if not, display state if valid
if (stateIndex > usStates.Count - 1)
{
    Console.WriteLine("The index you selected does not exist. Please run the program again and select a valid index.");
    return;
}
else
    Console.WriteLine("Here is the US state at index " + stateIndex + ": " + usStates[stateIndex]);