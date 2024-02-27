namespace Magic8Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MAGIC 8 BALL";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            string prompt1 = "It is certain";
            string prompt2 = "It is decidedly so";
            string prompt3 = "Without a doubt";
            string prompt4 = "Yes definitely";
            string prompt5 = "You may rely on it";
            string prompt6 = "As I see it, yes";
            string prompt7 = "Most likely";
            string prompt8 = "Outlook good";
            string prompt9 = "Yes";
            string prompt10 = "Signs point to yes";
            string prompt11 = "Reply hazy, try again";
            string prompt12 = "Ask again later";
            string prompt13 = "Better not tell you now";
            string prompt14 = "Cannot predict now";
            string prompt15 = "Concentrate and ask again";
            string prompt16 = "Don’t count on it";
            string prompt17 = "My reply is no";
            string prompt18 = "My sources say no";
            string prompt19 = "Outlook not so good";
            string prompt20 = "Very doubtful";

            string[] prompts = { prompt1, prompt2, prompt3, prompt4, prompt5, prompt6, prompt7, prompt8, prompt9, prompt10, prompt11, prompt12, prompt13, prompt14, prompt15, prompt16, prompt17, prompt18, prompt19, prompt20 };


            Console.WriteLine("Welcome to the Magic 8 Ball!\n");

            string magicBall = @"
                                    ,dP9CGG88@b,
                                  ,IP  _   Y888@@b,
                                 dIi  (_)   G8888@b
                                dCII  (_)   G8888@@b
                                GCCIi     ,GG8888@@@
                                GGCCCCCCCGGG88888@@@
                                GGGGCCCGGGG88888@@@@...
                                Y8GGGGGG8888888@@@@P.....
                                 Y88888888888@@@@@P......
                                 `Y8888888@@@@@@@P'......
                                    `@@@@@@@@@P'.......
                                        """"........";


            string responseBall = @"     
    ,dP9CGG88@b,
  ,IP  _   Y888@@b,
 dIi  (_)   G8888@b
dCII  (_)   G8888@@b
GCCIi     ,GG8888@@@
GGCCCCCCCGGG88888@@@
GGGGCCCGGGG88888@@@@...
Y8GGGGGG8888888@@@@P.....
 Y88888888888@@@@@P......
 `Y8888888@@@@@@@P'......
    `@@@@@@@@@P'.......
        """"........";

            Console.WriteLine(magicBall);

            bool uResponse = true;

            while (uResponse)
            {
                Random rand = new Random();
                int randomIndex = rand.Next(prompts.Length);
                Console.WriteLine("Ask a question:");
                Console.ReadLine();
                Console.WriteLine($"{responseBall}\"{prompts[randomIndex]}\"\n");
                Console.WriteLine("To ask another question press any key! Press \"N\" to exit.\n");
                ConsoleKey userA = Console.ReadKey(true).Key;

                if (userA == ConsoleKey.N)
                {
                    uResponse = false;
                }
            }



        }
    }
}
