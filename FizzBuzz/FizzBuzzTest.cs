namespace FizzBuzz;
using Xunit;

public class FizzBuzzTest
{
    [Fact]
    public void should_return_1_when_play_game_given_number_is_1()
    {
        int givenNumber = 1;
        
        string actualNumber = new FizzBuzz().PlayGame(givenNumber);
        
        Assert.Equal("1", actualNumber);
    }
}