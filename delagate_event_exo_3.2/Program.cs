using delagate_event_exo_3._2.models;


Interrupteur switch1 = new Interrupteur();
AfficherEtat screen1 = new AfficherEtat();

switch1.LightChange += screen1.EstAllume;

switch1.Allumer();
switch1.Eteindre();