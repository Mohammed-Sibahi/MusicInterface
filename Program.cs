using System; 

public interface IMusicPlayer
{
    public void Play();
    public void Pause();
    public void Stop();
    public void Next();
    public void Previous();

}

public class SimpleMusicPlayer : IMusicPlayer
{
    public void Play()
    {
        Console.WriteLine("Music played!");
    }

    public void Pause()
    {
        Console.WriteLine("Music paused!");
    }
    public void Stop()
    {
        Console.WriteLine("Music stopped!");
    }
    public void Next()
    {
        Console.WriteLine("Play next song!");
    }
    public void Previous()
    {
        Console.WriteLine("Play previous song!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IMusicPlayer player = new SimpleMusicPlayer();
        
        while (true)
        {
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. play");
            Console.WriteLine("2. pause");
            Console.WriteLine("3. stop");
            Console.WriteLine("4. next");
            Console.WriteLine("5. previous");
            Console.WriteLine();
            Console.WriteLine("Press (6) to exit.");

            if(int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                case 1:
                        player.Play();
                        break;
                case 2: 
                        player.Pause(); 
                        break;

                case 3: 
                        player.Stop(); 
                        break;

                case 4: 
                        player.Next(); 
                        break;

                case 5: 
                        player.Previous(); 
                        break;
                case 6:
                Console.WriteLine("Exiting the program.");
                        return;
                default: 
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }


            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            
            Console.WriteLine();
        }
    }
}