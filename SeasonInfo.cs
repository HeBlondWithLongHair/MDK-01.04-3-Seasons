using System;

public class SeasonInfo
{
    int temperature;
    Seasons season;

    public SeasonInfo(Seasons season, int temperature)
    {
        this.season = season;
        this.temperature = temperature;
    }

    public string getDescription()
    {
        if (season == Seasons.Summer)
        {
            return "Жаркое время года";
        }
        if (season == Seasons.Winter)
        {
            return "Холодное время года";
        }
        if (season == Seasons.Spring)
        {
            return "Теплое время года";
        }
        if (season == Seasons.Autumn)
        {
            return "Прохладное время года";
        }
        else
        {
            return "Нет такого время года";
        }

        
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Время года: {season}\nСредняя температура: {temperature} градусов\nОписание: {getDescription()}");
    }

    public static void PrintSeasondDescription(Seasons season)
    {
        switch (season)
        {
            case Seasons.Winter:
                Console.WriteLine("Зима - это время года, когда все покрыто снегом и очень холодно");
                break;

            case Seasons.Spring:
                Console.WriteLine("Весна - это время года, когда все начинает цвести и становится теплее");
                break;

            case Seasons.Summer:
                Console.WriteLine("Лето - мое любимое время года, тепло и красиво");
                break;

            case Seasons.Autumn:
                Console.WriteLine("Осень - это время года, когда опадают листь, становится холоднее");
                break;

        }    
    }
   



}






