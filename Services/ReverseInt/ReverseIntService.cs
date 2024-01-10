using System.Runtime.CompilerServices;

namespace MiniChallengeFiveToSeven___Endpoints.Services.ReverseInt;
public class ReverseIntService : IReverseIntService
{
    public string ReverseInt(string num)
    {
        int numParsed = 0;

        bool numIsTrue = int.TryParse(num, out numParsed);
        
        if(numIsTrue) {
            string backwards = "";

            for(int i = num.Length - 1; i>= 0; i--) {
                backwards += num[i];
            }
            return backwards;
        }
        return $"{num} is not valid";
    }
}