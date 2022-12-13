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
        [InlineData(1, 2, 3)]
        public void AddPlus(int a, int b, int c)

        {
            //Quand on a une chaîne (a,b,c)

            var entrée = $"{a},{b},{c}";

            //Et quand on appelle Add
            var résultat = CalculatorAdd.Add(entrée);

            //Elle renvoie l'addition de (a + b + c)
            Assert.Equal(a + b + c, résultat);
        }

        [Fact]
        public void SautDeLigne()
        {
            // ETANT DONNE une chaîne de nombres avec un saut de ligne

            var entrée = string.Join(',', new int[] { 1, 2, 3 });
            var EAvecS = CalculatorAdd.Add(entrée);

            // QUAND on appelle Add
            var SAvecS = CalculatorAdd.Add(entrée);

            // ALORS on obtient  la somme des nombres

            var SSansS = CalculatorAdd.Add(entrée);

            Assert.Equal(SSansS, SAvecS);
        }

        [Fact]
        public void NombresNégatifsNonAutorisés()
        {
            // ETANT DONNE une chaîne de nombres avec un chiffre négatif 
            var entrée = string.Join(',', new int[] { 1, 2, -3 });

            // QUAND on appelle Add
            void Act() => CalculatorAdd.Add(entrée);

            // Alors on retourne une exception avec la position du chiffre negatif

            var exception = Assert.Throws<ExceptionNBN>(Act);

            Assert.Equal(-1, exception.NombreFautif);
            Assert.Equal(-1, exception.Position);
        }

        [Fact]
        public void NombresGrand (int résultatPetitsnombres, int résultatGrandsNombres)
        {
            // Quand on a une chaîne de nombres comprenant un nombre >1000

            var nombres = new int[] { 1200, 1, 5 };
            var entrée = string.Join(',', nombres);

            //-> Add

            var résultatAvecGrandNombres = CalculatorAdd.Add(entrée);

            // Nb < à 1000

            var PetitsNombres = nombres.Where(nombres => nombres <= 1000);
            var entréePetitsNombres = string.Join(',', PetitsNombres);
            var résultatPetitsNombres = CalculatorAdd.Add(entréePetitsNombres);

            Assert.Equal(résultatPetitsNombres, résultatGrandsNombres);

        }


    }
}