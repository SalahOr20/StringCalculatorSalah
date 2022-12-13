using StringCalculatorSalah;

namespace UnitTest1.cs
{
    public class CalculatorTest
    {

        [Theory(DisplayName = "Lorsque on a une chaine (a,b) en entrée" +
                              "Et quand on appelle CalculatorAdd " +
                              "le retour sera l'addition de (a,b")]
        [InlineData(1, 2)]

        public void Testchar(int a, int b)
        {
            // Lorsque on a une chaine (1,2) en entrée"

            var entrée = $"{a},{b}";

            // Et quand on appelle Add

            var résultat = CalculatorAdd.Add(entrée);

            // le retour sera l'addition de a,b pour (1,2 elle renvoie 3)"

            Assert.Equal(a + b, résultat);



        }
        [Theory(DisplayName = "Lorsque on a une chaine (a,b,c) en entrée" +
                              "Et quand on appelle CalculatorAdd " +
                              "le retour sera l'addition de (a,b,c")]
        [InlineData(1,2,3)]
        public void AddPlus(int a, int b, int c)

        {
            //Quand on a une chaîne (a,b,c)

            var entrée = $"{a},{b},{c}";

            //Et quand on appelle Add
            var résultat = CalculatorAdd.Add(entrée);

            //Elle renvoie l'addition de (a + b + c)
            Assert.Equal(a + b + c, résultat);
        }

    }
 


}