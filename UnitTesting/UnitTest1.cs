using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDatabaseIsValid()
        {
            var db = new UnicornCustomer.Database.Customer();

            Assert.IsNotNull(db);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestDatabaseSave()
        {
            var db = new UnicornCustomer.Database.Customer();
            db.Save("Tom", "Thumb", "Greek", 12);
        }
    }
}
