class Program
{
    static void Main(string[] args)
    {
        var ops = new StudentOperations();

        Console.WriteLine("Creating student...");
        ops.Create("Alice", 20, "alice@example.com");

        Console.WriteLine("\nAll students:");
        ops.Read();

        Console.WriteLine("\nUpdating student...");
        ops.Update(1, "Alice Smith", 21, "alicesmith@example.com");

        Console.WriteLine("\nAll students:");
        ops.Read();

        Console.WriteLine("\nDeleting student...");
        ops.Delete(1);

        Console.WriteLine("\nAll students:");
        ops.Read();
    }
}
