using System;

namespace ProjectClasses
{
    [Serializable]
    public class StockItem
	{
		private int stockID;
		private Game game;
		private Customer customer;
		private DateTime issueDate;
		private DateTime dueDate;
		private bool isRented;
		private bool isReserved;
		
		public StockItem (int newStockID, Game newGame, Customer newCustomer)
		{
			stockID = newStockID;
			game = newGame;
            customer = newCustomer;
			isRented = false;
			isReserved = false;
            issueDate = new DateTime();
            dueDate = new DateTime();
		}

        public StockItem(int newStockID, DateTime newIssueDate, DateTime newDueDate, bool newIsRented, bool newIsReserved, bool newIsDamaged, Game newGame, Customer newCustomer)
        {
            stockID = newStockID;
            game = newGame;
            customer = newCustomer;
            isRented = newIsRented;
            isReserved = newIsReserved;
            issueDate = newIssueDate;
            dueDate = newDueDate;
        }

        public int StockID
		{
			get{return stockID;}
		}
			
		public Game Game
		{
			get{return game;}
		}
		
		public bool IsRented
		{
			get{return isRented;}
			set{isRented = value;}
		}
		
		public bool IsReserved
		{
			get{return isReserved;}
			set{isReserved = value;}
		}
		
		public Customer Customer
		{
			get{return customer;}
			set{customer = value;}
		}
		
		public DateTime IssueDate
		{
			get{return issueDate;}
            set{ issueDate = value; }
		}
		
		public DateTime DueDate
		{
			get{return dueDate;}
            set { dueDate = value; }
		}
		
		public bool RentGame(Customer customer, DateTime issueDate, DateTime dueDate)
		{
			//--Code Here--//
			return true;
		}
		
		public void ReturnGame()
		{
			//--Code Here--//
		}
		
		public bool HasCustomer(int custID)
		{
			//--Code Here--//
			return true;
		}
		
		public bool HasCustomer(string searchFirstName, string searchSurname)
		{
			//--Code Here--//
			return true;
		}
		
		public bool HasStockID(int searchStockID)
		{
            return searchStockID == this.stockID ? true : false;
		}
		
		public bool HasGameIDNotRented(int searchGameID)
		{
            return searchGameID == this.game.GameID && isRented == false ? true : false;
		}
		
		public bool IsCustomerOfAge()
		{
			return customer.Age < game.AgeCategory ? false:true;			
		}
		
		
	}
}

