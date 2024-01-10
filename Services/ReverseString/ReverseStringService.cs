namespace MiniChallengeFiveToSeven___Endpoints.Services.ReverseString;
public class ReverseStringService : IReverseStringService
{
    public string ReverseString(string forwards)
    {
        string backwards = "";
        
        for(int i = forwards.Length - 1; i>= 0; i--) {
            backwards += forwards[i];
        }
        return backwards;
    }
}