// See https://aka.ms/new-console-template for more information
using jmodul6_103022300052;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("APRIL");
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film kapten amerika oleh April");
        video1.IncreasePlayCount(123456);
        user.addVideo(video1);

        SayaTubeVideo video = new SayaTubeVideo("Review Film Home sweet loan oleh April");
        video = new SayaTubeVideo("Review Film Home sweet loan oleh April");
        video.IncreasePlayCount(12345);
        user.addVideo(video);

        for (int i = 0; i < 100; i++)
        {
            video.IncreasePlayCount(10000000);
        }

        video = new SayaTubeVideo("Review Film instatella oleh April");
        video.IncreasePlayCount(123456);
        user.addVideo(video);

        video = new SayaTubeVideo("Review Film Black panter oleh April");
        video.IncreasePlayCount(123456);
        user.addVideo(video);

        video = new SayaTubeVideo("Review Film Transformer oleh April");
        video.IncreasePlayCount(123456);
        user.addVideo(video);

        video = new SayaTubeVideo("Review Film Godzilla oleh April");
        video.IncreasePlayCount(123456);
        user.addVideo(video);

        video = new SayaTubeVideo("Review Film Teletubbies oleh April");
        video.IncreasePlayCount(123456);
        user.addVideo(video);

        video = new SayaTubeVideo("Review Film Ipar adalah maut oleh April");
        video.IncreasePlayCount(123456);
        user.addVideo(video);

        video = new SayaTubeVideo("Review Film Marvell oleh April");
        video.IncreasePlayCount(123456);
        user.addVideo(video);

        video = new SayaTubeVideo("Review Film Pabrik gula oleh April");
        video.IncreasePlayCount(123456);
        user.addVideo(video);

        video = new SayaTubeVideo("Review Film Romeo oleh April");
        video.IncreasePlayCount(123456);
        user.addVideo(video);

        video = new SayaTubeVideo("Review Film Batman oleh April");
        video.IncreasePlayCount(123456);
        user.addVideo(video);

        for (int i = 0; i < 10; i++)
        {
            video.IncreasePlayCount(10000000);
        }

        user.printAllVideoPlayCount();
        Console.WriteLine("Total play count: " + user.GetTotalVideoPlayCount());
    }
}