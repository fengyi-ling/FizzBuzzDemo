namespace FizzBuzz;

public class FizzBuzz
{
    public string PlayGame(int givenNumber)
    {
        
        if(IsMultipleOf5(givenNumber) && IsMultipleOf3(givenNumber))
        {
            return "FizzBuzz";
        }
        
        
        if(IsMultipleOf5(givenNumber))
        {
            return "Buzz";
        }
        
        if (IsMultipleOf3(givenNumber))
        {
            return "Fizz";
        }

        return givenNumber.ToString();
    }

    private static bool IsMultipleOf3(int givenNumber)
    {
        return givenNumber % 3 == 0;
    }

    private static bool IsMultipleOf5(int givenNumber)
    {
        return givenNumber % 5 == 0;
    }
}