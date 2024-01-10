namespace MiniChallengeFiveToSeven___Endpoints.Services.OddOrEven;
public class OddOrEvenService : IOddOrEvenService
{
    public string OddOrEven(string num) {
        int numParsed = 0;

        bool numIsTrue = int.TryParse(num, out numParsed);

        if(numIsTrue) {
            if(numParsed % 2 == 0) {
                return $"{num} is even";
            } else {
                return $"{num} is odd";
            }
        }
        return $"{num} is not a number";
    }
}