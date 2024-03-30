using modul6_1302223116;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Tutorial Design By Contract - Theo");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Tutorial User Centered Design - Theo");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Tutorial Algorithms - Theo");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Tutorial User Experience - Theo");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Tutorial User Interface - Theo");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Tutorial Software Modelling - Theo");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Tutorial Object Oriented Programming - Theo");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Tutorial Formal Methods - Theo");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Tutorial Human Computer Interaction - Theo");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Tutorial Database - Theo");
       
        video1.IncreasePlayCount(5);

        video1.PrintVideoDetails();
        video2.PrintVideoDetails();
        video3.PrintVideoDetails();
        video4.PrintVideoDetails();            
        video5.PrintVideoDetails();
        video6.PrintVideoDetails();            
        video7.PrintVideoDetails();                
        video8.PrintVideoDetails();            
        video9.PrintVideoDetails();
        video10.PrintVideoDetails();

        SayaTubeUser user = new SayaTubeUser("Theo");
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);
        user.PrintAllVideoPlayCount();
    }
}