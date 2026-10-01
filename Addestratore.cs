public class Addestratore : Umano, IDaSpettacolo
{
    public Addestratore(string nome, int eta, bool siEsibisce, DateTime? dataSpettacolo, string nickname) : base(nome, eta)
    {
        this.SiEsibisce = siEsibisce;
        this.dataSpettacolo = dataSpettacolo;
        this.nickname = nickname;
    }

    public DateTime? dataSpettacolo { get; set; }

    public bool SiEsibisce { get; set; }

    public string nickname { get; set; }

    public void EseguiTrucco()
    {
        Console.WriteLine($"{this.nickname} ({this.GetType()}) si esibisce alle {dataSpettacolo}"); 
    }
}
