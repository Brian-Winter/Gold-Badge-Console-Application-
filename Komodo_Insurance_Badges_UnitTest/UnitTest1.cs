using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Komodo_Insurance_Badges_Repository;
using System.Collections.Generic;

namespace Komodo_Insurance_Badges_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private BadgeRepository _testBadgeMethods = new BadgeRepository();
        private Badge _testBadges = new Badge();
        private List<BadgeRepository> _testDictionary = new List<BadgeRepository>();
        [TestMethod]
        public void TestMethod1()
        {
           
            _testBadgeMethods.AddNewBadge(1, new Badge(1, "a7"));
            _testBadgeMethods.AddNewBadge(2, new Badge(2, "a7"));
            _testBadgeMethods.AddNewBadge(3, new Badge(3, "a5"));
            _testBadgeMethods.AddNewBadge(4, new Badge(4, "a6"));

        }
        [TestMethod]
        public void TestMethod2()
        {
            _testBadgeMethods.AddNewBadge(1, new Badge(1, "a7"));
            _testBadgeMethods.AddNewBadge(2, new Badge(2, "a7"));
            _testBadgeMethods.AddNewBadge(3, new Badge(3, "a5"));
            _testBadgeMethods.AddNewBadge(4, new Badge(4, "a6"));

            Dictionary<int, Badge> allBadges = _testBadgeMethods.ViewAllBadges();

            foreach (KeyValuePair<int, Badge> content in allBadges)
            {
                Console.WriteLine("Badge ID: {0}, Door Access {1} ", content.Key, content.Value.DoorNames[0]);
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            _testBadgeMethods.CheckIfKeyExists(1);
            Console.WriteLine(_testBadgeMethods.CheckIfKeyExists(1));
        }

        //[TestMethod]
        //public void TestMethod4()
        //{
        //    _testBadgeMethods.AddNewBadge(1, new Badge(1, "a7"));
        //    _testBadgeMethods.AddDoorNumber(1);

        //}
    }
}
