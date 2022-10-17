namespace Test;

public class UnitTest1
{
    [Fact]
    public void ShouldAddBook()
    {
        Dictionary<string, Book> myDictionary = new Dictionary<string, Book>();
        myDictionary.Add("Book1",null);
     Assert.Equal(myDictionary.Return);
    }
}