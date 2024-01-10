namespace MiniChallengeFiveToSeven___Endpoints.Services.MadLib;
public class MadLibService : IMadLibService
{
    public string MadLib(string person, string adj, string age, string place, string activity, string personTwo, string adjTwo, string ageTwo, string activityTwo, string placeTwo){
        return $"{person}, age {age}, who is very {adj}, went to the {place} to {activity}. {person} met {personTwo}, who was {adjTwo}, but looked around the age of {ageTwo}. They then visitied a {placeTwo} to {activityTwo}";
    }
}