namespace delegate_event_exo_2._2.models;

public class FinTelechargement
{
  internal void AlerterFin(int pourcentage)
  {
    if (pourcentage >= 100)
    {
      Console.WriteLine(" - Téléchargement terminé");
    }
  }
}