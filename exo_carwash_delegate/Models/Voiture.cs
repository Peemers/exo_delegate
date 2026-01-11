namespace exo_carwash_delegate.Models;

public class Voiture
{
  
  //prop
  
  protected string Plaque { get; }
  
  //ctor
  public Voiture(string plaque)
  {
    Plaque = plaque;
  }
}