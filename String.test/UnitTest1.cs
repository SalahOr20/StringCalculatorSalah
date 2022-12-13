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
        [InlineData(1, 2, 3)]
        public void AddPlus(int a, int b, int c)

        {
            //Quand on a une cha�ne (a,b,c)

            var entr�e = $"{a},{b},{c}";

            //Et quand on appelle Add
            var r�sultat = CalculatorAdd.Add(entr�e);

            //Elle renvoie l'addition de (a + b + c)
            Assert.Equal(a + b + c, r�sultat);
        }

        [Fact]
        public void SautDeLigne()
        {
            // ETANT DONNE une cha�ne de nombres avec un saut de ligne

            var entr�e = string.Join(',', new int[] { 1, 2, 3 });
            var EAvecS = CalculatorAdd.Add(entr�e);

            // QUAND on appelle Add
            var SAvecS = CalculatorAdd.Add(entr�e);

            // ALORS on obtient  la somme des nombres

            var SSansS = CalculatorAdd.Add(entr�e);

            Assert.Equal(SSansS, SAvecS);
        }

        [Fact]
        public void NombresN�gatifsNonAutoris�s()
        {
            // ETANT DONNE une cha�ne de nombres avec un chiffre n�gatif 
            var entr�e = string.Join(',', new int[] { 1, 2, -3 });

            // QUAND on appelle Add
            void Act() => CalculatorAdd.Add(entr�e);

            // Alors on retourne une exception avec la position du chiffre negatif

            var exception = Assert.Throws<ExceptionNBN>(Act);

            Assert.Equal(-1, exception.NombreFautif);
            Assert.Equal(-1, exception.Position);
        }

        [Fact]
        public void NombresGrand (int r�sultatPetitsnombres, int r�sultatGrandsNombres)
        {
            // Quand on a une cha�ne de nombres comprenant un nombre >1000

            var nombres = new int[] { 1200, 1, 5 };
            var entr�e = string.Join(',', nombres);

            //-> Add

            var r�sultatAvecGrandNombres = CalculatorAdd.Add(entr�e);

            // Nb < � 1000

            var PetitsNombres = nombres.Where(nombres => nombres <= 1000);
            var entr�ePetitsNombres = string.Join(',', PetitsNombres);
            var r�sultatPetitsNombres = CalculatorAdd.Add(entr�ePetitsNombres);

            Assert.Equal(r�sultatPetitsNombres, r�sultatGrandsNombres);

        }


    }
}