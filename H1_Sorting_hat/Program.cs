namespace H1_Sorting_hat
{
    internal class Program
    {
        static void Main()
        {
            // Creates an instance to the hat class
            SortingHat hat = new SortingHat();

            // Infinite loop, so all the students get sorted
            // Because its Harry Potter, there magically appears infinite students
            while (true)
            {
                // Writes what the hat.house returns and sleep for 0.1 second
                Console.WriteLine(hat.House());
                Thread.Sleep(100);
            }
        }

    }
}