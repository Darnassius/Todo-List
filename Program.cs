internal class Program
{
    private static void Main(string[] args)
    {



        Console.WriteLine("Hello!, please press a key to initialise the program");
        Console.ReadKey();

        List<string> Todos = new List<string>();

        string[] validInputs = { "a", "A", "s", "S", "r", "R", "e", "E" };
        bool validInputSelected = true;
        string userInput = "";

        do
        {

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[S]ee all Todos");
            Console.WriteLine("[A]dd a Todo");
            Console.WriteLine("[R]emove a Todo");
            Console.WriteLine("[E]xit");
            userInput = Console.ReadLine();


            if (CheckIfUpper("s", userInput))
            {
                

                if (Todos.Count == 0)
                {
                    Console.WriteLine("You chose to see all the Todo's but no todos have been added yet!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("You Chose to see all Todo's");
                
                foreach(string chore in Todos)
                {
                    Console.WriteLine($"{Todos.IndexOf(chore)} - {chore}");
                }
                Console.ReadLine();
            }
            else if (CheckIfUpper("a", userInput))
            {
                    bool isContainedAlready = false;
                    string newTodo;
                    Console.WriteLine("You Chose to add a Todo");
                do
                {
                    
                    
                    
                    Console.WriteLine("Please type what the Todo is");
                    newTodo = Console.ReadLine();
                    if (Todos.Contains(newTodo))
                    {
                        isContainedAlready = true;
                        Console.WriteLine("You can not add this as it already exists");
                    } else
                    {
                        isContainedAlready = false;
                        Todos.Add(newTodo);
                    }

                    
                    
                        

                    
                  
                    
                } while (isContainedAlready);
            }
            else if (CheckIfUpper("r", userInput))
            {
                Console.WriteLine("You Chose to Remove a Todo");
                Console.WriteLine("Please type the index of what to remove");
                foreach (string chore in Todos)
                {
                    Console.WriteLine($"{Todos.IndexOf(chore)} - {chore}");
                }
                
                string toRemove = Console.ReadLine();
                int removeInt = int.Parse(toRemove);
                Todos.RemoveAt(removeInt);
                

            }
            else if (CheckIfUpper("e", userInput))
            {
                Console.WriteLine("You Chose to Exit");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else
            {
                validInputSelected = false;
                Console.WriteLine("You did not enter a valid input");
                Console.ReadLine();
            }

        } while (userInput != "e" || userInput != "E");




        static bool CheckIfUpper(string character1, string character2)
        {

            if (character1.ToUpper() == character2.ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }





        }

    }
}