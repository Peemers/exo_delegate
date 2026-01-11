using System.Globalization;

namespace delegate_event_exo_3.models;

public class AlerteParkingPlein
{
  internal void FullAlerte(int place)
  {
    if (place <= 0)
    {
      Console.WriteLine($"Parking Plein");
    }
  }
}