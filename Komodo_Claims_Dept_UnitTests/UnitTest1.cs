using System;
using Komodo_Claims_Dept_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Komodo_Claims_Dept_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private ClaimRepository _testClaimRepository = new ClaimRepository();
        private Claim _testClaim = new Claim();

        [TestMethod]
        public void TestMethod1()
        {
            Claim fClaim = new Claim(4, ClaimType.Car, "T-Bone Passenger Side", 3500, new DateTime(2020, 09, 21), new DateTime(2020, 09, 22), true);

            _testClaimRepository.AddNewClaim(fClaim);


            Console.WriteLine(fClaim.ClaimID);
            Console.WriteLine(_testClaimRepository.RemoveClaim(4));

            Console.WriteLine(_testClaimRepository.GetContentbyClaimId(4));

            Console.WriteLine(_testClaimRepository.ViewAllClaims());
        }
    }
}
