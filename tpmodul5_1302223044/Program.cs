internal class Program
{
    public class haloGeneric
    {
        public static void sapaUser<T>(T X)
        {
            Console.WriteLine("halo, " + X);
        }
    }
    private static void Main(string[] args)
    {
      
        haloGeneric.sapaUser("Hafid");
    }
}