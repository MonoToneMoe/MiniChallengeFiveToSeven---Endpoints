using System.Runtime.CompilerServices;

namespace MiniChallengeFiveToSeven___Endpoints.Services.ReverseInt;
public class ReverseIntService : IReverseIntService
{
    public string ReverseInt(string num)
    {
        int numParsed = 0;

        bool numIsTrue = int.TryParse(num, out numParsed);
        
        if(numIsTrue) {
            char[] charArray = num.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        return $"{num} is not valid";
    }
}