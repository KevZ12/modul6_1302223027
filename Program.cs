// See https://aka.ms/new-console-template for more information
namespace modul6_1302223027
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user1 = new SayaTubeUser("kevin");
            SayaTubeVideo video1 = new SayaTubeVideo("avenger");
            SayaTubeVideo video2 = new SayaTubeVideo("kaguya sama");
            SayaTubeVideo video3 = new SayaTubeVideo("attack on titan");
            SayaTubeVideo video4 = new SayaTubeVideo("naruto");
            SayaTubeVideo video5 = new SayaTubeVideo("kimino nawa");
            SayaTubeVideo video6 = new SayaTubeVideo("suzune");
            SayaTubeVideo video7 = new SayaTubeVideo("garden od word");
            SayaTubeVideo video8 = new SayaTubeVideo("death note");
            SayaTubeVideo video9 = new SayaTubeVideo("konosuba");
            SayaTubeVideo video10 = new SayaTubeVideo("5 gotoubun");


            user1.AddVideo(video1);
            user1.AddVideo(video2);
            user1.AddVideo(video3);
            user1.AddVideo(video4);
            user1.AddVideo(video5);
            user1.AddVideo(video6);
            user1.AddVideo(video7);
            user1.AddVideo(video8);
            user1.AddVideo(video9);
            user1.AddVideo(video10);

            video1.IncreasePlayCount(11);
            video2.IncreasePlayCount(18);   
            video3.IncreasePlayCount(33);
            video1.IncreasePlayCount(10);

            user1.printAllVideoPlayCount();


        }
    }
}