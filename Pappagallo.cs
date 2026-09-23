public class Pappagallo : Animale
{
    private double aperturaAlare;

    public Pappagallo(string n, int e, bool diurno, double alare): base(n, e, diurno)
    {
        this.aperturaAlare = alare;
    }

    public override string FaiVerso()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine("verso pappagallo");
        }
        return "";
    }
}