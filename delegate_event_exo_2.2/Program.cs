using delegate_event_exo_2._2.models;

Telechargeur t1 = new Telechargeur();
AfficheurProgression a1 = new AfficheurProgression();
FinTelechargement f1 = new FinTelechargement();

t1.ProgressionChangee += a1.AfficherProgression; 
t1.ProgressionChangee += f1.AlerterFin;

t1.Telecharger();