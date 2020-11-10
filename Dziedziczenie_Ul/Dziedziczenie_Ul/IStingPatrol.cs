namespace Dziedziczenie_Ul
{
    public interface IStingPatrol : IWorker
    {

        int AlertLevel { get; }
        int StingerLength { get; set; }

        bool LookForEnemies { get; }

        int SharpenStinger(int Length);



    }

    
}
