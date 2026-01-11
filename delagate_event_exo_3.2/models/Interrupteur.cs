namespace delagate_event_exo_3._2.models;

public class Interrupteur
{
  internal delegate void LightHandler(bool light);

  internal event LightHandler LightChange;

  private bool _enFonctionnement = false;

  internal void Allumer()
  {
    if (_enFonctionnement == false)
    {
      _enFonctionnement = true;
      LightChange?.Invoke(_enFonctionnement);
    }
    
  }
  internal void Eteindre()
  {
    if (_enFonctionnement == true)
    {
      _enFonctionnement = false;
      LightChange?.Invoke(_enFonctionnement);
    }
  }
}