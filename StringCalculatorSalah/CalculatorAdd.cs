namespace StringCalculatorSalah;

public class CalculatorAdd
{

    public static int Add(string entrée)

    
        {
            var part = entrée.Split(',');
            return part.Select(int.Parse).Sum();




        }
  



}
