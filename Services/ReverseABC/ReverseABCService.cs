namespace FiveToSeven.Services.ReverseABC;

public class ReverseABCService : IReverseABCService
{
    public string ReverseAlphanumeric(string inputSequence)
    {
        string reversedSequence = "";

        if (inputSequence == "")
            return "Please enter a sequence of letters and numbers";

        reversedSequence = new string(inputSequence.Reverse().ToArray());

        return $"Original Sequence: {inputSequence} - Reversed Sequence: {reversedSequence}";
    }
}