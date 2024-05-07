public class Input
{
    public static int GetValidIntInput()
    {
        bool validInput = false;
        int output = 0;
        // keeps asking for user input until the user gives a valid input
        while(!validInput) {
            string? input = Console.ReadLine();
            validInput = int.TryParse(input, out output);
            if (validInput) {
                output = Convert.ToInt32(input);
                break;
            }
            else {
                Console.WriteLine("Invalid choice!");
                Console.Write("Try again ");
            }
        }
        // return the input converted to int
        return output;
    }
}