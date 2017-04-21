using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Mangement_System
{

    class Manager : Employee
    {
        private static Manager instance;

        private Manager() { }

        public static Manager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Manager();
                }
                return instance;
            }
        }

    }
}
