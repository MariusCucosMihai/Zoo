using System.Text;
public class Pappagallo : Animale, IVolante
{
    private double aperturaAlare;

    public Pappagallo(string n, int e, bool diurno, bool siEsibisce, DateTime? dataSpettacolo, string nickname, double alare): base(n, e, diurno, siEsibisce, dataSpettacolo, nickname)
    {
        this.aperturaAlare = alare;
    }

    
    public void Vola()
    {
        Console.WriteLine("Il pappagallo sta volando! -  apertura alare: " + aperturaAlare);
    }

    public override string FaiVerso()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i <= 5; i++)
        {
            sb.Append($"\n verso pappagallo x {i}");
        }
        return sb.ToString();
    }
}