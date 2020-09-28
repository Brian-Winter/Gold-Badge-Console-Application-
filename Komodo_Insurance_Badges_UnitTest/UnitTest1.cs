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
            _testBadgeMethods.Doors();


            _testBadgeMethods.Loop();

            _testBadgeMethods.TestMe(1, "NameMeAString");

           Console.WriteLine(_testBadgeMethods)
        }
       
    }
}
