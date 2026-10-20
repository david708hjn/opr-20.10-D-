namespace Strategy
{
    public class PlatbaKartou : IStrategie
    {
        public void Zaplatit(decimal castka)
    {
        Console.WriteLine($"Platba kartou {castka} Kč.");
    
    

    }
}