using System;
using ConvertNumToWords;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertNumToWordsTest
{
    [TestClass]
    public class ConvertNumToWordsTests
    {
        [TestMethod]
        public void TestForMultipleInstances()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            IConvertNumToWords c2 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            Assert.IsTrue(c1 == c2);
        }
        [TestMethod]
        public void convertToWordsTestForZero()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            string actual = c1.convertToWords(0);
            Assert.AreEqual("Zero", actual);
        }

        [TestMethod]
        public void convertToWordsTestForDoubleDigits()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            string actual = c1.convertToWords(11);
            Assert.AreEqual("eleven", actual);
        }

        [TestMethod]
        public void convertToWordsTestForThreeDigits()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            string actual = c1.convertToWords(111);
            string expected = "one hundred and eleven";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertToWordsTestForFourDigits()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            string actual = c1.convertToWords(1111);
            string expected = "one thousand one hundred and eleven";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertToWordsTestForFiveDigits()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            string actual = c1.convertToWords(11111);
            string expected = "eleven thousand one hundred and eleven";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertToWordsTestForSixDigits()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            string actual = c1.convertToWords(111111);
            string expected = "one lakh eleven thousand one hundred and eleven";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertToWordsTestForSevenDigits()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            string actual = c1.convertToWords(1111111);
            string expected = "eleven lakh eleven thousand one hundred and eleven";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertToWordsTestForEightDigits()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            string actual = c1.convertToWords(11111111);
            string expected = "one crore eleven lakh eleven thousand one hundred and eleven";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertToWordsTestForNineDigits()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            string actual = c1.convertToWords(111111111);
            string expected = "eleven crore eleven lakh eleven thousand one hundred and eleven";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertToWordsTestForMaxLimit()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            string actual = c1.convertToWords(999999999);
            string expected = "ninety nine crore ninety nine lakh ninety nine thousand nine hundred and ninety nine";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertToWordsTestForNegativeInput()
        {
            IConvertNumToWords c1 = ConvertNumToWords.ConvertNumToWords.GetInstance();
            string actual = c1.convertToWords(-9);
            string expected = string.Empty;
            Assert.AreEqual(expected, actual);
        }

    }
}
