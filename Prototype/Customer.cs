using System;

namespace ProjectClasses
{
    [Serializable]
	public class Customer : Person
	{
		private int custID;
		private bool isRenting;

		
		public Customer(int newCustID, string newFirstName, string newSurname, string newAddress, int newAge, string newMobile)
			:base(newFirstName,newSurname,newAddress,newAge,newMobile)
		{
			custID = newCustID;
			isRenting = false;
            
		}

        public int CustID
		{
			get{return custID;}
		}
		
		public bool IsRenting
		{
			get{return isRenting;}
			set{isRenting = value;}
		}

        public bool HasID(int searchCustomerID)
        {
            return searchCustomerID == this.custID ? true : false;
        }
        public bool HasName(string searchName)
        {
            return searchName == this.firstName ? true : false;
        }

    }
}

