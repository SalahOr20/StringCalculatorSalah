namespace StringCalculatorSalah;

public class ExceptionNBN
{
    internal ExceptionNBN(int position, string nombreFautif)
    {
        Position = position;
        NombreFautif = nombreFautif;
    }

    public int Position { get; }
    public string NombreFautif { get; }
}












