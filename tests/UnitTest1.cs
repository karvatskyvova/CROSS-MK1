using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace MK1.Tests
{
    [TestClass]
    public class ProgramTests
    {
        // Тестування функції CountStringsAndSets
        [TestMethod]
        public void TestCountStringsAndSets()
        {
            // Тест 1
            var result = Program.CountStringsAndSets(3, 2);
            Assert.AreEqual(14, result.Item1);  // Очікуване значення totalStrings
            Assert.AreEqual(1, result.Item2);   // Очікуване значення totalSets

            // Тест 2
            result = Program.CountStringsAndSets(5, 3);
            Assert.AreEqual(363, result.Item1);  // Очікуване значення totalStrings
            Assert.AreEqual(1, result.Item2);    // Очікуване значення totalSets
        }

        // Тестування зчитування та запису в файли
        [TestMethod]
        public void TestFileInputOutput()
        {
            // Запис тестових даних у INPUT.TXT
            File.WriteAllText("INPUT.TXT", "3 2\n");

            // Виконання програми
            Program.Main(new string[] { });

            // Читання результату з OUTPUT.TXT
            string[] output = File.ReadAllLines("OUTPUT.TXT");

            // Перевірка правильності запису результатів
            Assert.AreEqual("14", output[0]);
            Assert.AreEqual("1", output[1]);
        }
    }
}
