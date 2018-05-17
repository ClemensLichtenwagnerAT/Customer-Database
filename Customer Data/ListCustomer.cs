
using Customer_Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibary
{
    /// <summary>
    ///  TODO
    /// </summary>
    public class ListCustomer
    {
        private List<Customer> _List;
        private string _DataBaseName;
        private string _Password;

        #region Constructor
        public ListCustomer()
        {
            List = new List<Customer>();
        }
        #endregion

        #region Properties

        public List<Customer> List
        {
            get
            {
                return this._List;
            }
            private set
            {
                this._List = value;
            }
        }

        public string DataBaseName
        {
            get
            {
                return this._DataBaseName;
            }
            private set
            {
                this._DataBaseName = value;
            }
        }

        public string Password
        {
            get
            {
                return this._Password;
            }
            private set
            {
                this._Password = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CreateNewDataBase(string name, string password)
        {
            string path = @"H:\MaSem2\SE\Project\"+name+".csv";
            if(!File.Exists(path))
            {
                File.WriteAllText(path, password);
                return true;
            }
            else
            {
                return false;
            }         
        }

        public bool LoadDataBase(string name, string password)
        {          
            string path = @"H:\MaSem2\SE\Project\" + name + ".csv";
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }else if(File.ReadLines(path).First().Equals(password))
            {
                DataBaseName = name;
                Password = password;

                string[] lines = File.ReadAllLines(path);
                lines = lines.Skip(1).ToArray();
                foreach (string line in lines)
                {                   
                    string[] parts = line.Split(';');
                    Customer newCustomer = new Customer(Convert.ToInt16(parts[0]), parts[1], parts[2], parts[3], Convert.ToDouble(parts[4]), Convert.ToDateTime(parts[5]));
                    List.Add(newCustomer);
                }

                return true;
            }else
            {
                return false;
            }
            
        }

        public bool UpdateDatabase()
        {
            try
            {
                string path = @"H:\MaSem2\SE\Project\" + DataBaseName + ".csv";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(Password);

                foreach(Customer customer in List)
                {
                    string line = customer.CustomerID + ";" + customer.FirstName + ";" + customer.LastName + ";" + customer.EmailAddress + ";" + customer.OpenBalance.ToString() + ";" + customer.LastChange.ToString();
                    sb.AppendLine(line);
                }
                File.WriteAllText(path,sb.ToString());

                return true;
            }catch(Exception)
            {
                return false;
            }
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                customer.CustomerID = List.Count + 1;
                List.Add(customer);
                return true;

            }catch(Exception)
            {
                return false;
            }

        }

        public bool checkTODO()
        {
            //TODO
            return false;
        }





        #endregion

    }
}
