namespace MiniChallengeFiveToSeven___Endpoints.Services.ReverseString;
public class ReverseStringService : IReverseStringService
{
    public string ReverseString(string forwards)
    {
        char[] charArray = forwards.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}