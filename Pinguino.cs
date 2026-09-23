public class Pinguino : Animale
{
    private double velocitaNuovo;

    public Pinguino(string n, int e, bool diurno, double vNuoto): base(n, e, diurno)
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