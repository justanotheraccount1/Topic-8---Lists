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
            for (int i = 0; i <= names.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + names[i]);
            }

            Console.ReadLine(); // Keeps program from closing 
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6 }; Console.WriteLine(nums[0] + " is 'The One'.");
            Console.WriteLine(nums[3] + " is 4");
            Console.WriteLine("There are " + nums.Count + " numbers in my List."); nums[3] = 14;
            Console.WriteLine(nums[3] + " is now 14.");
            Console.WriteLine(nums[nums.Count - nums.Count]);
            Console.WriteLine(nums[4] + " isn't in The Matrix...");
            Console.WriteLine(nums[nums.Count - 1] + " is the real bad guy");
            Console.WriteLine(nums[rand]);
            Console.ReadLine(); // Keeps program from closing
        }
    }
}
