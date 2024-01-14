using Birthday_Candles;
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> candles = new List<int>
    {
        8, 3, 2, 1, 3, 6, 8, 2, 8
    };

        int result = Result.birthdayCakeCandles(candles);
        Console.WriteLine(result);
    }
}