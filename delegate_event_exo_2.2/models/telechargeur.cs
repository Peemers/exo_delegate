namespace delegate_event_exo_2._2.models;

internal class Telechargeur
{
  // Delegate
  internal delegate void ProgressionHandler(int pourcentage);

  // Event
  internal event ProgressionHandler? ProgressionChangee;

  // Méthode métier : le téléchargeur décide de la progression
  internal void Telecharger()
  {
    int[] etapes = { 0, 25, 50, 75, 100 };

    Console.WriteLine("Téléchargement démarré");

    foreach (int p in etapes)
    {
      ProgressionChangee?.Invoke(p);
    }
  }
}