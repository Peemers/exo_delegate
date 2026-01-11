namespace exologger_delegate.models;

//délégué

public delegate void Pipeline(string message);

public class Logger
{
  //prop
  
  private static Pipeline _Traitement { get; set; }
  
  //ctor

  public Logger()
  {
    _Traitement = Salut;
    _Traitement += AuRevoir;
    _Traitement += Adieu;
  }
  
  //methode

  private static void Salut(string message)
  {
    Console.WriteLine($"salut la compagnie {message}");
  }

  private static void AuRevoir(string message)
  {
    Console.WriteLine($"Au revoir la compagnie {message}");
  }

  private static void Adieu(string message)
  {
    Console.WriteLine($"Adieu je ne reviendrai plus {message}");
  }

  public void Traiter(string message)
  {
    
    _Traitement(message);
  }
}