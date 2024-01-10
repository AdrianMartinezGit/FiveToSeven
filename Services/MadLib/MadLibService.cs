namespace FiveToSeven.Services.MadLib;

public class MadLibService : IMadLibService
{
    public string CreateStory(string place, string creature, string pronouns, string adjective, string verb, string adverb, string noun, string otherverb, string othernoun, string customending)
    {
        if (place == "")
            return "Please enter a place";
        if (creature == "")
            return "Please enter a living creature (Fiction or Non-Fiction)";
        if (pronouns == "")
            return "Please enter living creature's pronouns (He, She, They)";
        if (adjective == "")
            return "Please enter an adjective";
        if (verb == "")
            return "Please enter a verb (Ends with a 's')";
        if (adverb == "")
            return "Please enter an adverb";
        if (noun == "")
            return "Please enter a noun (Thing)";
        if (otherverb =="")
            return "Please enter a verb (Ends with a 'ed')";
        if (othernoun == "")
            return "Please enter a noun (Theme/Season)";
        if (customending == "")
            return "Please enter how the ending plays out (Story is up to User Interpretation)";

        return $"Story so far: In the land of {place}, would a {creature} walk about on a marked path, it was here that {pronouns} would see something so {adjective} that it makes the {creature} question their {verb} and {adverb} fled to find a {noun}, only to come back and see {pronouns} was/were {otherverb}, a reminder that on this {othernoun}, {customending}";
    }
}