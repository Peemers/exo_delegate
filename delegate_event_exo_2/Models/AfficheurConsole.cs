namespace delegate_event_exo_2.Models;

public class AfficheurConsole
{
  internal void Afficher(int temperature)
  {
    Console.WriteLine($"{temperature}");
  }
}