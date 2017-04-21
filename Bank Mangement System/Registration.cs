using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Bank_Mangement_System
{
    class Registration
    {
        public Employee Log_in(string name, int PassWord)
        {
            FileStream fs = new FileStream("Employee.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split(',');
                Employee emp = new Employee(arr[0], int.Parse(arr[1]), arr[2], arr[3], arr[4], int.Parse(arr[5]), arr[6], arr[7]);
                //name, int iD, address, phone, college,int graduationYear, totalgrade, position
                if (arr[0] == name)
                {
                    if (int.Parse(arr[1]) == PassWord)
                    {
                        sr.Close();
                        return emp;
                    }
                }
            }
            Employee empty = new Employee();
            sr.Close();
            return empty;
        }
        public Client Log_in(string username, string PassWord)
        {
            FileStream fs = new FileStream("Client.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split(',');
                Client _client = new Client(arr[0], arr[1], arr[2], arr[3], arr[4], double.Parse(arr[5]), bool.Parse(arr[6]), int.Parse(arr[8]), double.Parse(arr[7]));
                if (_client.UserName == username)
                {
                    if (_client.Password == PassWord)
                    {
                        sr.Close();
                        return _client;
                    }
                }
            }
            sr.Close();
            Client wrong = new Client();
            return wrong;
        }
    }
}
