using System;

namespace ProjectClasses
{ 
    [Serializable]
	public class Game
	{
		private int gameID;
		private string title;
		private string category;
		private string releaseYear;
		private int ageCategory;
		private int numCopies;
		
		public Game(int newGameID, string newTitle, string newCategory, string newreleaseYear, int newAgeCategory, int newNumCopies)
		{
			gameID = newGameID;
			title = newTitle;
			category = newCategory;
			releaseYear = newreleaseYear;
			ageCategory = newAgeCategory;
			numCopies = newNumCopies;
		}
		
		public int GameID
		{
			get{return gameID;}
		}
		
		public string Title
		{
			get{return title;}
			set{title = value;}
		}
		
		public string Category
		{
			get{return category;}
			set{category = value;}
		}
		
		public string ReleaseYear
		{
			get{return releaseYear;}
			set{releaseYear = value;}
		}
		
		public int AgeCategory
		{
			get{return ageCategory;}
			set{ageCategory = value;}
		}
		
		public int NumCopies
		{
			get{return numCopies;}
			set{numCopies = value;}
		}
		
		public bool IsOutOfStock()
		{
			return numCopies <= 0 ? true : false;
		}
		
		public bool HasID(int searchGameID)
		{
			return searchGameID == this.gameID ? true : false;
		}
		
		public bool HasTitle(string searchTitle)
		{
			return searchTitle == this.title ? true : false;
		}
		
		public bool HasCategory(string searchCategory)
		{
			return searchCategory == this.category ? true : false;
		}
		
		public bool HasAgeCategory(int searchAgeCategory)
		{
			return searchAgeCategory == this.ageCategory ? true : false;
		}
	}
}

