// Listing 9-8

using CleanCodeChapter9;

namespace TestSerialDate
{
    [TestClass]
    public class TestSerialDate
    {
        // Bad example, too many things in one test method 
        [TestMethod]
        public void TestAddMonths()
        {
            SerialDate d1 = SerialDate.CreateInstance(31, 5, 2004);
            SerialDate d2 = SerialDate.AddMonths(1, d1);

            Assert.AreEqual(30, d2.GetDayOfMonth());
            Assert.AreEqual(6, d2.GetMonth());
            Assert.AreEqual(2004, d2.GetYYYY());

            SerialDate d3 = SerialDate.AddMonths(2, d1);
            Assert.AreEqual(31, d3.GetDayOfMonth());
            Assert.AreEqual(7, d3.GetMonth());
            Assert.AreEqual(2004, d3.GetYYYY());

            SerialDate d4 = SerialDate.AddMonths(1, SerialDate.AddMonths(1, d1));
            Assert.AreEqual(30, d4.GetDayOfMonth());
            Assert.AreEqual(7, d4.GetMonth());
            Assert.AreEqual(2004, d4.GetYYYY());
        }

        // Better examples, split into separate methods which each test one thing
        [TestMethod]
        public void TestAddingOneMonthWhenAtThe31st()
        {
            SerialDate d1 = SerialDate.CreateInstance(31, 5, 2004);
            SerialDate d2 = SerialDate.AddMonths(1, d1);

            Assert.AreEqual(30, d2.GetDayOfMonth());
            Assert.AreEqual(6, d2.GetMonth());
            Assert.AreEqual(2004, d2.GetYYYY());
        }

        [TestMethod]
        public void TestAddingTwoMonths()
        {
            SerialDate d1 = SerialDate.CreateInstance(31, 5, 2004);
            SerialDate d3 = SerialDate.AddMonths(2, d1);
            Assert.AreEqual(31, d3.GetDayOfMonth());
            Assert.AreEqual(7, d3.GetMonth());
            Assert.AreEqual(2004, d3.GetYYYY());
        }

        [TestMethod]
        public void TestAddingThis() 
        {
            SerialDate d1 = SerialDate.CreateInstance(31, 5, 2004);
            SerialDate d4 = SerialDate.AddMonths(1, SerialDate.AddMonths(1, d1));
            Assert.AreEqual(30, d4.GetDayOfMonth());
            Assert.AreEqual(7, d4.GetMonth());
            Assert.AreEqual(2004, d4.GetYYYY());
        }
    }
}