namespace delegate_event_exo_3.models;

public class Parking
{
  private readonly int _capaciteMax = 50;
  private int _placeLibre = 50;

  internal delegate void PlaceHandler(int placeLibre);
  internal event PlaceHandler? PlaceModifie;

  internal void PrendrePlace()
  {
    if (_placeLibre == 0)
    {
      return;
    }
    
    _placeLibre--;
    PlaceModifie?.Invoke(_placeLibre);
  }

  internal void LibererPlace()
  {
    if (_placeLibre == _capaciteMax)
      return;

    _placeLibre++;
    PlaceModifie?.Invoke(_placeLibre);
  }
}