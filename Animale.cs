public abstract class Animale : IVisitabile,  IDaSpettacolo
{
    protected string nome;
    protected int eta;
    protected bool IsDiurno;

    public Animale(string n, int e, bool diurno, bool siEsibisce, DateTime? dataSpettacolo, string nickname)
    {
        this.nome = n;
        this.eta = e;
        this.IsDiurno = diurno;
        this.SiEsibisce = siEsibisce;
        this.dataSpettacolo = dataSpettacolo;
        this.nickname = nickname;
    }

    public abstract string FaiVerso();

    public virtual string Mangia(){
        return "L'animale sta mangiando...";
    }

    public string GetInfo(){
        return $"nome: {nome}, età: {eta}, {(IsDiurno ? "diurno" : "notturno")}";
    }

    public bool SiEsibisce { get; }

    public DateTime? dataSpettacolo { get; set; }

    public DateTime DataUltimoControllo { get; set; }

    public virtual void EseguiTrucco()
    {
        Console.WriteLine($"{this.nickname} ({this.GetType()}) si esibisce alle {dataSpettacolo}");   
    }

    public string nickname { get; set; }

    void IVisitabile.EseguiControllo()
    {
        DataUltimoControllo = DateTime.Now;
        Console.WriteLine($"Controllo eseguito su {nome} - specie: {this.GetType()} alle {DataUltimoControllo}");
    }

}