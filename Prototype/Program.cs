using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectClasses;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype
{
    public class Program
    {
        //Lists
        public static List<Game> gameList = new List<Game>();
        public static List<StockItem> stockList = new List<StockItem>();
        public static List<Customer> customerList = new List<Customer>();
        public static List<Employee> staffList = new List<Employee>();
        public static List<Account> accountList = new List<Account>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        public static void SaveGames()
        {
            BinaryFormatter bformatter = new BinaryFormatter();
            FileStream gameDB = new FileStream("GameDB.bin", FileMode.Create, FileAccess.Write);
            bformatter.Serialize(gameDB, gameList);
            gameDB.Close();
        }

        public static void LoadGames()
        {
            if (File.Exists("GameDB.bin") && new FileInfo("GameDB.bin").Length != 0)
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                FileStream gameDB = new FileStream("GameDB.bin", FileMode.Open, FileAccess.Read);
                gameList = bformatter.Deserialize(gameDB) as List<Game>;
                gameDB.Close();
            }
        }

        public static void SaveStock()
        {
            BinaryFormatter bformatter = new BinaryFormatter();
            FileStream stockDB = new FileStream("StockDB.bin", FileMode.Create, FileAccess.Write);
            bformatter.Serialize(stockDB, stockList);
            stockDB.Close();
        }

        public static void LoadStock()
        {
            if (File.Exists("StockDB.bin") && new FileInfo("StockDB.bin").Length != 0)
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                FileStream stockDB = new FileStream("StockDB.bin", FileMode.Open, FileAccess.Read);
                stockList = bformatter.Deserialize(stockDB) as List<StockItem>;
                stockDB.Close();
            }
        }

        public static void SaveCustomer()
        {
            BinaryFormatter bformatter = new BinaryFormatter();
            FileStream customerDB = new FileStream("CustomerDB.bin", FileMode.Create, FileAccess.Write);
            bformatter.Serialize(customerDB, customerList);
            customerDB.Close();
        }

        public static void LoadCustomers()
        {
            if (File.Exists("CustomerDB.bin") && new FileInfo("CustomerDB.bin").Length != 0)
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                FileStream customerDB = new FileStream("CustomerDB.bin", FileMode.Open, FileAccess.Read);
                customerList = bformatter.Deserialize(customerDB) as List<Customer>;
                customerDB.Close();
            }
        }

        public static void SaveStaff()
        {
            BinaryFormatter bformatter = new BinaryFormatter();
            FileStream staffDB = new FileStream("StaffDB.bin", FileMode.Create, FileAccess.Write);
            bformatter.Serialize(staffDB, staffList);
            staffDB.Close();
        }

        public static void LoadStaff()
        {
            if (File.Exists("StaffDB.bin") && new FileInfo("StaffDB.bin").Length != 0)
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                FileStream staffDB = new FileStream("StaffDB.bin", FileMode.Open, FileAccess.Read);
                staffList = bformatter.Deserialize(staffDB) as List<Employee>;
                staffDB.Close();
            }

        }

        public static void SaveAcc()
        {
            BinaryFormatter bformatter = new BinaryFormatter();
            FileStream accDB = new FileStream("AccDB.bin", FileMode.Create, FileAccess.Write);
            bformatter.Serialize(accDB, accountList);
            accDB.Close();
        }

        public static void LoadAcc()
        {
            if (File.Exists("AccDB.bin") && new FileInfo("AccDB.bin").Length != 0)
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                FileStream accDB = new FileStream("AccDB.bin", FileMode.Open, FileAccess.Read);
                accountList = bformatter.Deserialize(accDB) as List<Account>;
                accDB.Close();
            }

        }

        public static int GetNextStaffID()
        {
            int lastID = 0;
            int nextID = 0;
            if (staffList.Count() != 0)
            {
                lastID = staffList[staffList.Count() - 1].EmpID;
                nextID = lastID + 1;
                return nextID;
            }
            else
            {
                nextID = 1;
                return nextID;
            }

        }

        public static int GetNextGameID()
        {
            int lastID = 0;
            int nextID = 0;
            if (gameList.Count() != 0)
            {
                lastID = gameList[gameList.Count() - 1].GameID;
                nextID = lastID + 1;
                return nextID;
            }
            else
            {
                nextID = 100;
                return nextID;
            }
        }

        public static int GetNextStockID()
        {
            int lastID = 0;
            int nextID = 0;
            if (stockList.Count() != 0)
            {
                lastID = stockList[stockList.Count() - 1].StockID;
                nextID = lastID + 1;
                return nextID;
            }
            else
            {
                nextID = 1;
                return nextID;
            }

        }

        public static int GetNextCustomerID()
        {
            int lastID = 0;
            int nextID = 0;
            if (customerList.Count() != 0)
            {
                lastID = customerList[customerList.Count() - 1].CustID;
                nextID = lastID + 1;
                return nextID;
            }
            else
            {
                nextID = 1000;
                return nextID;
            }

        }

        public static int GetNextAccID()
        {
            int lastID = 0;
            int nextID = 0;
            if (accountList.Count() != 0)
            {
                lastID = accountList[accountList.Count() - 1].AccID;
                nextID = lastID + 1;
                return nextID;
            }
            else
            {
                nextID = 10000;
                return nextID;
            }

        }
    }
}
