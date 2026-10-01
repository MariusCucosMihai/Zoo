public class Leone : Animale
{
    private int volumeRuggito;

    public Leone(string n, int e, bool diurno, bool siEsibisce, DateTime? dataSpettacolo, string nickname, int volume) : base(n, e, diurno, siEsibisce, dataSpettacolo, nickname)
    {
        volumeRuggito = Math.Clamp(volume, 1, 10);
    }

    public override string FaiVerso()
    {
        return "ROAAR!";
    }

    public override string Mangia()
    {
        return "Il leone mangia carne fresca";
    }

}