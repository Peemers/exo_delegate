using delegate_event_exo_2.Models;

CapteurTemperature cap1  = new CapteurTemperature();
AfficheurConsole aff1 = new AfficheurConsole();
AfficheurAlerte tWarning =  new AfficheurAlerte();

cap1.TemperatureCheck += aff1.Afficher;
cap1.TemperatureCheck += tWarning.HighTempAlert;

cap1.Mesurer(35);
