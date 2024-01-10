namespace MiniChallengeFiveToSeven___Endpoints.Services.MadLib;
public class MadLibService : IMadLibService
{
    public string MadLib(string person, string adj){
        return $"{person} is {adj}.";
    }
}