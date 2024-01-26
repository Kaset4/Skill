using VideoLibrary;
using NYoutubeDL;
using YouTubeApp;

public class Program
{
    static void Main(string[] args)
    {
        CommandsYouTube commandsYouTube = new CommandsYouTube();

        commandsYouTube.Download("https://youtu.be/-zxGTDiplKY?si=EJZVVlTCv0ag5ctG", "D:\\my\\");
        Console.WriteLine();
        commandsYouTube.GetInfo("https://youtu.be/-zxGTDiplKY?si=EJZVVlTCv0ag5ctG");
    }
}