namespace delagate_event_exo_3._2.models;

public class AfficherEtat
{
  internal void EstAllume(bool state)
  {
    if (state == true)
    {
      Console.WriteLine("ON");
    }

    if (state == false)
    {
      Console.WriteLine("OFF");
    }
  }
}