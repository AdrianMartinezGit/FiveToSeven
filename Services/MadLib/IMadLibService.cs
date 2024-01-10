namespace FiveToSeven.Services.MadLib;

public interface IMadLibService
{
    string CreateStory(string place, string creature, string pronouns, string adjective, string verb, string adverb, string noun, string otherverb, string othernoun, string customending);     
}