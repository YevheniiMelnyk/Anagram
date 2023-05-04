using ConsoleApp1;

namespace AnagramTesting
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void Reverse_ValidString()
        {
            string input = "hello world";
            string expectedOutput = "olleh dlrow";

            string output = Anagram.Reverse(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void Reverse_ValidStringWithNonLetters()
        {
            string input = "hel3lo$, wor@ld?/";
            string expectedOutput = "oll3eh$, dlr@ow?/";

            string output = Anagram.Reverse(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Reverse_NullString()
        {
            string expectedOutput = Anagram.Reverse(null);
        }

        [TestMethod]
        public void Reverse_OnlySpacesString()
        {
            string input = "   ";
            string expectedOutput = "   ";

            string output = Anagram.Reverse(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void Reverse_OnlyNonLettersString()
        {
            string input = "$_21,#%78 ";
            string expectedOutput = "$_21,#%78 ";

            string output = Anagram.Reverse(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void Reverse_MoreThenOneSpaceString()
        {
            string input = "   hel3lo$,  wor@ld?/    ";
            string expectedOutput = "   oll3eh$,  dlr@ow?/    ";

            string output = Anagram.Reverse(input);

            Assert.AreEqual(expectedOutput, output);
        }
    }
}