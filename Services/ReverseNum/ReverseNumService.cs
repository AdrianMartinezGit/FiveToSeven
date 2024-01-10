namespace FiveToSeven.Services.ReverseNum;

public class ReverseNumService : IReverseNumService
{
    public string ReverseNumerical(string inputSequence)
    {
        string reversedSequence = "";
        int firstNumberSequence = 0;
        int secondNumberSequence = 0;
        bool dataVerified = int.TryParse(inputSequence, out firstNumberSequence);

        if (dataVerified == false) {
            return "Please enter a sequence of real numbers";
        }

        if (inputSequence == "")
            return "Please enter a sequence of letters and numbers";

        reversedSequence = new string(inputSequence.Reverse().ToArray());

        int.TryParse(reversedSequence, out secondNumberSequence);

        return $"Original Sequence: {firstNumberSequence} - Reversed Sequence: {secondNumberSequence}";
    }
}
