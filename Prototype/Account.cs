using System;

namespace ProjectClasses
{
    [Serializable]
	public class Account
	{
		private int accID;
		private Customer customer;
		private int joinFee;
		private int rentFee;
		private int lateFee;
		
		public Account(int newAccID, Customer newCustomer)
		{
			accID = newAccID;
			customer = newCustomer;
			joinFee = 20;
			rentFee = 0;
			lateFee = 0;
		}
		
		public int AccID
		{
			get{return accID;}
		}
		
		public Customer Customer
		{
			get{return customer;}
		}
		
		public int JoinFee
		{
			get{return joinFee;}
		}
		
		public int RentFee
		{
			get{return rentFee;}
		}
		
		public int LateFee
		{
			get{return lateFee;}
		}
			
		public void UpdateRentFee(int amount)
		{
            rentFee += amount;
		}
		
		public void UpdateLateFee(int amount)
		{
            lateFee += amount;
		}
		
		public bool HasCustomerID(int searchID)
		{
            return customer.HasID(searchID) ? true : false;
		}
	}
}

