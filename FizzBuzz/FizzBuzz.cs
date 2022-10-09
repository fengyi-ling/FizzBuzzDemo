namespace FizzBuzz;

public class FizzBuzz
{
    public string PlayGame(int givenNumber)
    {
        
        if(givenNumber % 15 == 0)
        {
            return "FizzBuzz";
        }
        
        
        if(givenNumber % 5 == 0)
        {
            return "Buzz";
        }
        
        if (givenNumber % 3 == 0)
        {
            return "Fizz";
        }

        return givenNumber.ToString();
    }
}