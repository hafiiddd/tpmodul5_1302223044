using static Program;

internal class Program
{
    public class haloGeneric
    {
        public void sapaUser<T>(T X)
        {
            Console.WriteLine("halo, " + X);
        }
    }
    public class DataGeneric<Generic>
    {
        private Generic data;
        public DataGeneric(Generic inputdata)
        {
            this.data = inputdata;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
    private static void Main(string[] args)
    {
        haloGeneric halo = new haloGeneric();
        halo.sapaUser("Hafid AlAkhyar");

        Console.Write("NIM: ");
        string nim = Console.ReadLine();
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
}
