public abstract class Animale
{
    protected string nome;
    protected int eta;
    protected bool IsDiurno;

    public Animale(string n, int e, bool diurno)
    {
        this.nome = n;
        this.eta = e;
        this.IsDiurno = diurno;
    }

    public abstract string FaiVerso();

    public virtual string Mangia(){
        return "L'animale sta mangiando...";
    }

    public string GetInfo(){
        return $"nome: {nome}, età: {eta}, {(IsDiurno ? "diurno" : "notturno")}";
    }



}