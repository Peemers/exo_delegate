using delegate_event_exo2._3.models;

Batterie bat1 = new Batterie();
AfficheurBatterie aff1 = new AfficheurBatterie();
AlerteBatteriePleine warn1 = new AlerteBatteriePleine();
AlerteBatterieFaible warn2 = new AlerteBatterieFaible();

bat1.NiveauAChange += aff1.AfficherBatterie;
bat1.NiveauAChange += warn1.AlerteFull;
bat1.NiveauAChange += warn2.AlerteFaible;

bat1.Simuler();
bat1.Simuler();
bat1.Simuler();
bat1.Simuler();
bat1.Simuler();
