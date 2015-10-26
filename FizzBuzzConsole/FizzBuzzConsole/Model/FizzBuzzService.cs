
namespace FizzBuzzConsole.Model
{
    public class FizzBuzzService
    {
        public string FormatNumber(int candidate)
        {
            if (candidate % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (candidate % 3 == 0)
            {
                return "Fizz";
            }
            if (candidate % 5 == 0)
            {
                return "Buzz";
            }
            return candidate.ToString();
        }
    }
}
