// See https://aka.ms/new-console-template for more information

namespace My_First_Project
{

    class Program
  {
      private static void Main(string[] args)
    {
        // Init Veriables
        string theMatrix, system, neo, enemy, inside, save, unplugged, fight;
        string[] professions = new string[4], adj = new string[2];
        // Get Imput from User
        Console.WriteLine("welcome user!");
        Console.WriteLine("Let's play a game of madlibs");
        Console.WriteLine("please sharre with me your name");
        neo = Console.ReadLine();

            // Getting matrix veriiable from user
       Console.WriteLine($"Hello {neo}! are you ready?" +
            $" What would you like to know more about?");

        theMatrix = Console.ReadLine();
    
            // Getting system variable from user
        Console.WriteLine($"Oooh! You want to know more about {theMatrix} huh");
        Console.WriteLine($"Well first tell me what you already know about {theMatrix}");
        Console.WriteLine($"What noun would you categorize {theMatrix} as?");
        system = Console.ReadLine();


            //Gettin enemy veriable from user
            Console.WriteLine($"Give me an opposing noun to {system}");
            enemy = Console.ReadLine();

            //Getting inside veriavle from user
            Console.WriteLine($"Now give me any relaxing noun (present tense)");
            inside = Console.ReadLine();

            //Getting all professions from user
            Console.WriteLine($"Okay now i need 4 professions relating to {system}");
            for (int i = 0; i < professions.Length; i++)
            {
                Console.WriteLine($"professions (plural) {i + 1} / {professions.Length}");
                professions[i] = Console.ReadLine();

            }

            //Getting save variable from user
            Console.WriteLine($"Give me a hero related verb (present tense)");
            save = Console.ReadLine();

            //Getting unplugged variable from user
            Console.WriteLine($"Now give me a verb that makes you think about relief (past tense)");
            unplugged = Console.ReadLine();


            //Getting the adjectives
            Console.WriteLine($"Lastly i need 2 dystopian adjectives");

            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine($"adjective {i + 1} / {adj.Length}:");
                adj[i] = Console.ReadLine();
            }

            //Getting fight variable from user
            Console.WriteLine($"and a verb:");
            fight = Console.ReadLine();


        // Init Story
        string madlibsStory =
        $"{theMatrix} is a {system}, {neo}. That {system} is our {enemy}." +
        $"But when you're {inside}, you look around, what do you see?" +
        $"" +
        $"{professions[0]}, {professions[1]}, {professions[2]} {professions[3]}" +
        $"The very minds of the people we are trying to {save}." +
        $"But until we do, these people are still a part of that {system}" +
        $"and that makes them our {enemy}." +
        $"You have to understand, most of these people are not ready to be {unplugged}." +
        $"And many of them are so {adj[0]}, so hopelessly {adj[1]} on the {system}," +
        $"that they will {fight} to protect it.";

        // Print Story
        Console.WriteLine(madlibsStory);
        Console.ReadKey();
    }
  }
}