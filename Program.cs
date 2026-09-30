void Main(){
    Zoo zoo = new Zoo();

    Leone l = new Leone("leone", 10, true, 10);
    Pinguino p = new Pinguino("pingu", 5, false, 50.0);
    Pappagallo pap = new Pappagallo("pappa", 67, true, 15.0);

    zoo.AggiungiAnimale(l);
    zoo.AggiungiAnimale(p);
    zoo.AggiungiAnimale(pap);

    foreach(Animale a in zoo.Animali)
    {
        Console.WriteLine(a.FaiVerso());
        Console.WriteLine(a.Mangia());
        ((IVisitabile)a).EseguiControllo();

        if (a is IVolante)
        {
            IVolante v = (IVolante)a;
            v.Vola();
        }

        if (a.GetType() == typeof(Pinguino))
        {
            Pinguino ping = (Pinguino)a;
            ping.Nuota();
        }
    }
}

Main();