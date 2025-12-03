namespace ConsoleApp3.Program.Tests
{

    [TestClass]
    public class WordSearcherTests
    {
        [TestMethod]
        [DataRow("ByeBye", "hello", false)]    // Атрибут ПЕРЕД методом
        [DataRow("hheeeeeellllllshdfhsdhdllooooo world", "hello", true)]   // Разные регистры
        [DataRow("Good morning", "hello", false)]  // Слова нет
        [DataRow("Hello", "Hello", true)]              // Пустая строка
        [DataRow("Hello", "Hesdfllahg", false)]              // Пустое слово для поиска
        [DataRow("0747", "hello", false)]    // Атрибут ПЕРЕД методом
        [DataRow("Hello world", "789", false)]   // Разные регистры
        [DataRow("111112222233333", "123", true)]  // Слова нет
        [DataRow(" ", "Hello", false)]

        public void SearchWordTest(string strok, string wordSearcher, bool expectedAnswer)
        {
            // Act
            var actualAnswer = WordSearcher.SearchWord(strok, wordSearcher);

            // Assert
            Assert.AreEqual(expectedAnswer, actualAnswer, $"Ошибка для слова: '{strok}', не нашлось слово : '{wordSearcher}' или был не верно выбран парамметр '{expectedAnswer}'");
        }
    }

}