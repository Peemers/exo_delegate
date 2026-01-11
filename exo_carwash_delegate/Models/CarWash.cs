namespace exo_carwash_delegate.Models;

//délégué? oui :)

delegate void TraitementVoitureDelegate(Voiture v);

public class CarWash
{
  private TraitementVoitureDelegate _traitement;
  
  //ctor
  public CarWash()
  {
    _traitement = Preparer;
    _traitement += Laver;
    _traitement += Secher;
    _traitement += Finaliser;
  }
  
  //methodes
  
  private void Preparer(Voiture v)
  {
    Console.WriteLine("Je prépare la voiture");
  }

  private void Laver(Voiture v)
  {
    Console.WriteLine("Je lave la voiture");
  }

  private void Secher(Voiture v)
  {
    Console.WriteLine("Je seche la voiture");
  }

  private void Finaliser(Voiture v)
  {
    Console.WriteLine("Je finaliser la voiture");
  }

  public void Traiter(Voiture v)
  {
    {
      _traitement(v);
    }
  }
}