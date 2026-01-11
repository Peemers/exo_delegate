namespace delegate_event_exo_2.Models;

public class CapteurTemperature
{
  //delegate
  
  internal delegate void TemperatureHandler(int temperature);
  
  //event
  
  internal event TemperatureHandler? TemperatureCheck;
  
  public void Mesurer(int temperature)
  {
    TemperatureCheck?.Invoke(temperature);
  }
}