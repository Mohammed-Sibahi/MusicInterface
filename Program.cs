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