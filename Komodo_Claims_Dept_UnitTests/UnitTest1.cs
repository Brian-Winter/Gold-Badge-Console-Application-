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
        public void AddNewTest()
        {
            Claim fClaim = new Claim(4, ClaimType.Car, "T-Bone Passenger Side", 3500, new DateTime(2020, 09, 21), new DateTime(2020, 09, 22), true);

            _testClaimRepository.AddNewClaim(fClaim);


            Console.WriteLine(fClaim.ClaimID);
            
        }
        [TestMethod]
        public void ViewAllTest()
        {
            Claim fClaim = new Claim(4, ClaimType.Car, "T-Bone Passenger Side", 3500, new DateTime(2020, 09, 21), new DateTime(2020, 09, 22), true);
           // _testClaimRepository.AddNewClaim(fClaim); Allows Display of 1 item in content

            Console.WriteLine(_testClaimRepository.ViewAllClaims().Count);
        }
        [TestMethod]
        public void RemovalTest()
        {
            Claim fClaim = new Claim(4, ClaimType.Car, "T-Bone Passenger Side", 3500, new DateTime(2020, 09, 21), new DateTime(2020, 09, 22), true);
            _testClaimRepository.AddNewClaim(fClaim);

            Console.WriteLine(_testClaimRepository.RemoveClaim(4));
        }
        [TestMethod]
        public void GetContentbyClaimIdTest()
        {
            Claim fClaim = new Claim(4, ClaimType.Car, "T-Bone Passenger Side", 3500, new DateTime(2020, 09, 21), new DateTime(2020, 09, 22), true);
            _testClaimRepository.AddNewClaim(fClaim);

            Console.WriteLine(_testClaimRepository.GetContentbyClaimId(4).Description);
        }
    }
}
