public interface IDaSpettacolo
{
    public bool SiEsibisce { get; }
    public DateTime? dataSpettacolo { get; set; }
    public string nickname { get; set; }
    public void EseguiTrucco();
}