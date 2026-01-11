using delegate_event_exo_3.models;

Parking p1 = new Parking();
AlerteParkingPlein war1 = new AlerteParkingPlein();
JournalEvenements event1 = new JournalEvenements();
AfficheurPlace screen =  new AfficheurPlace();

p1.PlaceModifie += war1.FullAlerte;
p1.PlaceModifie += event1.Enregistrer;
p1.PlaceModifie += screen.AfficherPlace;

p1.LibererPlace();
p1.PrendrePlace();
p1.PrendrePlace();
p1.PrendrePlace();
p1.PrendrePlace();
p1.PrendrePlace();