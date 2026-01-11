namespace delegate_event_exo_3.models;

public class JournalEvenements
{
  internal void Enregistrer(int placeLibre)
  {
    Console.WriteLine($"[LOG] Changement d'état du parking — places libres : {placeLibre}");
  }
}