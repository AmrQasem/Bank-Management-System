using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Bank_Mangement_System
{
    class Employee : Person
    {
        public string Position { set; get; }
        public string College { set; get; }
        public int GraduationYear { set; get; }
        public int ID { set; get; }
        public string Totalgrade { set; get; }
        public Employee() { }
        public Employee(string name, int iD, string address, string phone, string college, int graduationYear, string totalgrade, string position)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Position = position;
            College = college;
            GraduationYear = graduationYear;
            ID = iD;
            Totalgrade = totalgrade;
        }
        public override void add()
        {
            string data = "";
            FileStream fs = new FileStream("Employee.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string delemter = ",";
            data += "" + this.Name + delemter + this.ID + delemter + this.Address + delemter + this.Phone + delemter + this.College + delemter + this.GraduationYear + delemter + this.Totalgrade + delemter + this.Position;
            sw.WriteLine(data);
            data = "";
            sw.Close();

        }
        public bool deleteEmployee(string name, string Password)
        {
            int count = 0;
            FileStream fs = new FileStream("Employee.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<string> lineList = new List<string>();
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split(',');
                if (arr[0] == name)
                {
                    if (arr[1] == Password)
                    {

                        if (arr[7] == "Manager")
                        {
                            sr.Close();
                            return false;
                        }
                        sr.Close();
                        lineList = File.ReadAllLines("Employee.txt").ToList();
                        lineList.RemoveAt(count);
                        File.WriteAllLines(("Employee.txt"), lineList.ToArray());
                        return true;
                    }
                }
                count++;

            }
            sr.Close();
            return false;
        }
        public bool CloseAccount(int accountNumber)
        {
            bool x = false;
            FileStream fs = new FileStream("Client.txt", FileMode.Open);
            FileStream newfile = new FileStream("NewClient.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(newfile);
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split(',');

                if (int.Parse(arr[8]) == accountNumber)
                {
                    if (bool.Parse(arr[6]) == true)
                    {
                        x = true;
                        arr[6] = "False";
                        line = arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "," + arr[5] + "," + arr[6] + "," + arr[7] + "," + arr[8];
                        //return true;
                    }
                }
                sw.WriteLine(line);
            }
            sw.Close();
            sr.Close();
            File.Delete("Client.txt");
            File.Copy("NewClient.txt", "Client.txt");
            File.Delete("NewClient.txt");

            return x;
        }
    }

}