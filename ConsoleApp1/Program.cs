// See https://aka.ms/new-console-template for more information

public class Question1()
{
    public static void Main(string[] args)
    {
        PrintMenu();       
        GetMessage();
    }

    public static void PrintMenu()
    {
        Console.WriteLine("Please enter a valid option from below:");
        Console.WriteLine("1. Hello in French");
        Console.WriteLine("2. Hello in Spanish");
        Console.WriteLine("3. Hello in German");
        Console.WriteLine("4. Hello in Italian");
        Console.WriteLine("0. Exit application");
    }

    public static int InputOption()
    {
        try
        {

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Console.WriteLine(option);
                    return option;
                    
                case 1:
                    Console.WriteLine(option);
                    return option;
                  
                case 2:
                    Console.WriteLine(option);
                    return option;
                   
                case 3:
                    Console.WriteLine(option);
                    return option;
                    
                case 4:
                    Console.WriteLine(option);
                    return option;
                    
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    return option;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error. {ex.Message}");
        }
        return 0;
        
    }  

    public static void GetMessage()
    {
        int option = InputOption();
        switch (option)
        {
            case 0:
                Console.WriteLine("Goodbye");
                break;
            case 1:
                Console.WriteLine("Bonjour");
                break;
            case 2:
                Console.WriteLine("Ola");
                break;
            case 3:
                Console.WriteLine("Hallo");
                break;
            case 4:
                Console.WriteLine("Ciao");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
              break ;
        
    }   
    }
}



 

