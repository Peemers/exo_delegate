namespace delegate_event_exo_2.Models;

public class AfficheurAlerte
{
  internal void HighTempAlert(int temperature)
  {
    if (temperature > 30)
    {
      Console.WriteLine($" Attention température trop haute : {temperature}");
    }
  }
}