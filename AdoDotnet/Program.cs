class Program
{
    static void Main(string[] args)
    {
        var ops = new StudentOperations();

        Console.WriteLine("Creating student...");
        ops.Create("Ram", 20, "ram@example.com");

        Console.WriteLine("\nAll students:");
        ops.Read();

        Console.WriteLine("\nUpdating student...");
        ops.Update(1, "Isha Situng Magar", 21, "ishasm@example.com");

        Console.WriteLine("\nAll students:");
        ops.Read();

        Console.WriteLine("\nDeleting student...");
        ops.Delete(1);

        Console.WriteLine("\nAll students:");
        ops.Read();
    }
}

