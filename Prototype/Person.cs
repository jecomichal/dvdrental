using System;

namespace ProjectClasses
{
    [Serializable]
	public abstract class Person
	{
		protected string firstName;
		protected string surname;
		protected string address;
		protected int age;
		protected string mobile;
		
		public Person(string newFirstName, string newSurname, string newAddress, int newAge, string newMobile)
		{
			firstName = newFirstName;
			surname = newSurname;
			address = newAddress;
			age = newAge;
			mobile = newMobile;
		}
		
		public string FirstName
		{
			get{return firstName;}
			set{firstName = value;}
		}
		
		public string Surname
		{
			get{return surname;}
			set{surname = value;}
		}
		
		public string Address
		{
			get{return address;}
			set{address = value;}
		}
		
		public int Age
		{
			get{return age;}
			set{age = value;}
		}
		
		public string Mobile
		{
			get{return mobile;}
			set{mobile = value;}
		}
		
		
	}
}


