namespace PostStackOverflow {
    internal class Program {
        static void Main(string[] args) {
            
            Post zeldaPost = new Post("ToTK is the best!", "We're not talking enough...", DateTime.Now);
            bool votes = false;
            int upVotes = 0;
            int downVotes = 0;
            bool numberOfTimes = true;

            Console.WriteLine(zeldaPost.Title);
            Console.WriteLine(zeldaPost.Description);
            Console.WriteLine(zeldaPost.Datetime);

            while (numberOfTimes) {
                Console.WriteLine("Vote 0 if you like the post. Vote 1 if you don't.");
                int voteEntry = int.Parse(Console.ReadLine());

                if (voteEntry == 0) {
                    votes = true;
                    upVotes = zeldaPost.VoteUp(votes);
                } else if (voteEntry == 1) {
                    votes = false;
                    downVotes = zeldaPost.VoteDown(votes);
                }

                Console.WriteLine("Would you like to vote again? 0 = yes; 1 = no");
                int voteAgain = int.Parse(Console.ReadLine());

                if (voteAgain != 0) {
                    numberOfTimes = false;
                }
            }

            Console.WriteLine($"You're ups are {upVotes} and you're downs are {downVotes}.");
            
        }
    }
}