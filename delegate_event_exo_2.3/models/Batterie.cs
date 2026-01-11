namespace delegate_event_exo2._3.models;

public class Batterie
{
  internal delegate void NiveauHandler(int pourcentage);

  internal event NiveauHandler NiveauAChange;

  internal void Simuler()
  {
    int[] charge = {100, 75, 50, 25, 0};
    Console.WriteLine("Pas branché - décharge en cours");
    foreach (var i in charge)
    {
      NiveauAChange?.Invoke(i);
    }
  }
}