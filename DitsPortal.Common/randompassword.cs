namespace DitsPortal.Common
{
    public class randompassword
    {
        Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        // Generates a random number within a range.      
        static void Main(string[] args)
        {
            Console.ReadLine();


        }


    }
}
