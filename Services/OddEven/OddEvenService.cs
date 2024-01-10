namespace FiveToSeven.Services.OddEven;

public class OddEvenService : IOddEvenService
{
    public List<string> messageDisplay = new List<string>();
    
    public List<string> OddOrEvenNumber(string numberInput)
    {
        int number = 0;
        bool verified = int.TryParse(numberInput, out number);

        if (verified == true) {
            messageDisplay.Add($"String is a valid number. The value is: {number}.");
            
            if (number % 2 == 0) {
                messageDisplay.Add($"The number(s) {number} is even!");
            } else {
                messageDisplay.Add($"The number(s) {number} is odd!");
            }

            return messageDisplay;
        } else {
            messageDisplay.Add("String is not a valid number. Please try again.");
            return messageDisplay;
        }
    }
}
