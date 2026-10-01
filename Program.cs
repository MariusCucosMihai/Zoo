void Main(){
    Zoo zoo = new Zoo();

    Addestratore ad = new Addestratore("marius", 18, true, DateTime.Now, "marius");
    Addestratore ad2 = new Addestratore("mario", 20, true, DateTime.Now, "mario");

    List<Umano> addestratori = new List<Umano>();
    addestratori.Add(ad);
    addestratori.Add(ad2);

    Leone l = new Leone("leone", 10, true, true, DateTime.Now, "pippo", 10);
    Pinguino p = new Pinguino("pingu", 5, false, false, null, "pingu", 50.0);
    Pappagallo pap = new Pappagallo("pappa", 67, true, true, DateTime.Now, "pappa", 15.0);

    zoo.AggiungiAnimale(l);
    zoo.AggiungiAnimale(p);
    zoo.AggiungiAnimale(pap);

    foreach(Umano a in addestratori)
    {
        if ((a is IDaSpettacolo daSpettacolo) && daSpettacolo.SiEsibisce)
        {
            ((IDaSpettacolo)a).EseguiTrucco();
        }
    }

    foreach(Animale a in zoo.Animali)
    {
        /*
        Console.WriteLine(a.FaiVerso());
        Console.WriteLine(a.Mangia());
        ((IVisitabile)a).EseguiControllo();
        */

        //Console.WriteLine(a.SiEsibisce);

        if (a.SiEsibisce)
        {
            a.EseguiTrucco();
        }

        /*
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
        */
    }

    
}

Main();