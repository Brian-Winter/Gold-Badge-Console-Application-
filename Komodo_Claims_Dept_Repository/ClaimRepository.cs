using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims_Dept_Repository
{
   
    
   public class ClaimRepository
    {
        private List<Claim> _listofClaims = new List<Claim>();
       

        //View all Claims
        public List<Claim> ViewAllClaims()
        {
            return _listofClaims;
        }
        

        

        //Create new Claim
        public void AddNewClaim(Claim newContent)
        {
            _listofClaims.Add(newContent);
        }

        // Remove Claim
        public bool RemoveClaim(int claimNumber)
        {
            Claim content = GetContentbyClaimId(claimNumber);
            
            if(content == null)
            {
                return false;
            }
            int numberOfClaims = _listofClaims.Count;
            _listofClaims.Remove(content);

            if(numberOfClaims > _listofClaims.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Find by ID Method
        public Claim GetContentbyClaimId(int claimNumber)
        {
            foreach (Claim content in _listofClaims)
            {
                if (content.ClaimID == claimNumber)
                {
                    return content;
                }
            }
            return null;
        }

    }
}
