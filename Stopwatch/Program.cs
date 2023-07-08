namespace Stopwatch {
    internal class Program {
        static void Main(string[] args) {

            DateTime startWatch = new DateTime();
            DateTime endWatch = new DateTime();
            bool watch = true;

            while (watch) {

                Console.WriteLine("Press 0 to start the stopwatch and 1 to end it.");
                int start = int.Parse(Console.ReadLine());

                if (start == 0) {
                    startWatch = Stopwatch.Start();
                } else if (start == 1) {
                    watch = false;
                    endWatch = Stopwatch.Stop();
                }

            }

            TimeSpan result = endWatch.Subtract(startWatch);

            Console.WriteLine($"Your timespan was {result}");

        }
    }
}