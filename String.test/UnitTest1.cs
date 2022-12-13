using StringCalculatorSalah;

namespace UnitTest1.cs
{
    public class CalculatorTest
    {

        [Theory(DisplayName = "Lorsque on a une chaine (a,b) en entr�e" +
                              "Et quand on appelle CalculatorAdd " +
                              "le retour sera l'addition de (a,b")]
        [InlineData(1, 2)]

        public void Testchar(int a, int b)
        {
            // Lorsque on a une chaine (1,2) en entr�e"

            var entr�e = $"{a},{b}";

            // Et quand on appelle Add

            var r�sultat = CalculatorAdd.Add(entr�e);

            // le retour sera l'addition de a,b pour (1,2 elle renvoie 3)"

            Assert.Equal(a + b, r�sultat);



        }
        [Theory(DisplayName = "Lorsque on a une chaine (a,b,c) en entr�e" +
                              "Et quand on appelle CalculatorAdd " +
                              "le retour sera l'addition de (a,b,c")]
        [InlineData(1,2,3)]
        public void AddPlus(int a, int b, int c)

        {
            //Quand on a une cha�ne (a,b,c)

            var entr�e = $"{a},{b},{c}";

            //Et quand on appelle Add
            var r�sultat = CalculatorAdd.Add(entr�e);

            //Elle renvoie l'addition de (a + b + c)
            Assert.Equal(a + b + c, r�sultat);
        }

    }
 


}