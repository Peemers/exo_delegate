namespace delegate_event_exo2._3.models;

internal class AlerteBatterieFaible
{
  internal void AlerteFaible(int pourcentage)
  {
    if (pourcentage <= 15)
    {
      Console.WriteLine($" Batterie Faible : {pourcentage}%");
    }
  }
}