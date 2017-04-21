using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_Mangement_System
{
    class Client : Person 
    {
        
        public static int Account_Number;
        public string UserName { set; get; }
        public string Password { set; get; }
        public string TelephoneNumber { set; get; }
        public double Balance { set; get; }
        public bool StateOfAccount { set; get; }
        public double OldLoan { set; get; }

        public Client()
        {
            FileStream fs = new FileStream("Client.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            int x = 0;
            string[] info = new string[9];
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                info = line.Split(',');
            }
            sr.Close();
            x = int.Parse(info[8]);
            Account_Number = 1 + x;
            UserName = null;
            Password = null;
            TelephoneNumber = null;
            Balance = 0;
            OldLoan = 0;
            StateOfAccount = true;
        }

        public Client(string username, string pass, string name, string address, string phone, double balance,bool AccountState,int numaccount,double Client_Loan)
        {
            Account_Number = numaccount;
            UserName = username;
            Password = pass;
            Name = name;
            Address = address;
            Phone = phone;
            Balance = balance;
            OldLoan = Client_Loan;
            StateOfAccount = AccountState;
        }

        public override void add()
        {
            FileStream fs = new FileStream("Client.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string delemter = ",";
            string data = this.UserName + delemter + this.Password + delemter + this.Name + delemter + this.Address + delemter + this.Phone + delemter + this.Balance + delemter + this.StateOfAccount + delemter + this.OldLoan + delemter + Client.Account_Number;
            sw.WriteLine(data);
            sw.Close();
        }
         
        public bool IsActive()
        {
            return this.StateOfAccount;
        }

        public bool PayLoan(double amount)
        {
            if (this.OldLoan >= amount)
            {
                this.OldLoan -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool WithDraw(double amount)
        {
            if (this.Balance > amount)
            {
                this.Balance -= amount;
                return true;
            }
            else
            {
                //Console.WriteLine("Your Balance is not enough.");
                return false;
            }
        }

        public void Loan(double amount)
        {
            
            this.OldLoan += amount;
            
        }
        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                this.Balance += amount;
                return true;
            }
            else
                return false;
        }
        public void update()
        {
            FileStream fs = new FileStream("Client.txt", FileMode.Open);
            FileStream newfile = new FileStream("NewClient.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(newfile);
            //List<string> lineList = new List<string>();
            //int count = 0;
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split(',');
                if (arr[0] == this.UserName)
                {
                    if (arr[1] == this.Password)
                    {
                        arr[5] = this.Balance.ToString();
                        arr[7] = this.OldLoan.ToString();
                        line = arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "," + arr[5] + "," + arr[6] + "," + arr[7] + "," + arr[8];
                    }
                }
                sw.WriteLine(line);
                //count++;
            } 
            sw.Close();
            sr.Close();
        }
        
    }
}
