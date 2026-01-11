namespace delegate_event_exo2._3.models;

internal class AlerteBatteriePleine
{
  internal void AlerteFull(int pourcentage)
  {
    if (pourcentage == 100)
    {
      Console.WriteLine($"Batterie pleine {pourcentage}%");
    }
  }
}