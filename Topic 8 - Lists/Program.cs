namespace Topic_8___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int rand = generator.Next(6);
            List<string> names = new List<string> { "Trinity", "Neo", "Morpheus", "Smith", "Bailey Hines", "Cypher" }; Console.WriteLine(names[1] + " is 'The One'.");
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine("There are " + names.Count + " names in my List."); names[3] = "Agent Smith";
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine(names[names.Count - names.Count]);
            Console.WriteLine(names[4] + " isn't in The Matrix...");
            Console.WriteLine(names[names.Count - 1] + " is the real bad guy");
            Console.WriteLine(names[rand]);
            Console.ReadLine(); // Keeps program from closing 

        }
    }
}
