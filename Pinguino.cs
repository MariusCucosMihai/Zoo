public class Pinguino : Animale
{
    private double velocitaNuovo;

    public Pinguino(string n, int e, bool diurno, bool siEsibisce, DateTime? dataSpettacolo, string nickname, double vNuoto): base(n, e, diurno, siEsibisce, dataSpettacolo, nickname)
    {
        this.velocitaNuovo = vNuoto;
    }

    public override string FaiVerso()
    {
        return "Squittio acuto!";
    }

    public override string Mangia()
    {
        return base.Mangia();
    }

    public void Nuota(){}

}