public class Zoo
{
    private List<Animale> animali;

    public Zoo()
    {
        animali = new List<Animale>();
    }

    public void AggiungiAnimale(Animale animale)
    {
        animali.Add(animale);
    }

    public void EseguiAppello()
    {
        foreach (Animale animale in animali)
        {
            Console.WriteLine(animale.FaiVerso());
        }
    }

    public void AlimentaTUtti()
    {
        foreach (Animale animale in animali)
        {
            Console.WriteLine(animale.Mangia());
        }
    }
}