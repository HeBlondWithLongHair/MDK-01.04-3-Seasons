using System;

class Programm
{
    public static void Main(string[] args)
    {
        SeasonInfo winter = new SeasonInfo(Seasons.Winter, -20);
        SeasonInfo spring = new SeasonInfo(Seasons.Spring, +5);
        SeasonInfo summer = new SeasonInfo(Seasons.Summer, +25);
        SeasonInfo autumn = new SeasonInfo (Seasons.Autumn, 0);

        winter.PrintInfo();
        spring.PrintInfo();
        summer.PrintInfo();
        autumn.PrintInfo();

        Console.WriteLine();

        foreach (Seasons season in Enum.GetValues(typeof(Seasons)))
        {
            SeasonInfo.PrintSeasondDescription(season);

        }


    }

}





