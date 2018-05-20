using Customer_Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Customer_Data
{
    /// <summary>
    ///  TODO
    /// </summary>
    public class ListCustomer
    {
        //Kommentar
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
            string path = @"c:\Datenbanken\" + name + ".csv";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, EncodeWord(password, true));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoadDataBase(string name, string password)
        {
            string path = @"c:\Datenbanken\" + name;
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
            else if (File.ReadLines(path).First().Equals(EncodeWord(password, true)))
            {
                DataBaseName = name;
                Password = password;

                string[] lines = File.ReadAllLines(path);
                lines = lines.Skip(1).ToArray();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');

                    for (int i = 1; i < parts.Length - 1; i++)
                    {
                        parts[i] = EncodeWord(parts[i], false);
                    }

                    Customer newCustomer = new Customer(Convert.ToInt16(parts[0]), parts[1], parts[2], parts[3], Convert.ToDouble(parts[4]), Convert.ToDateTime(parts[5]));
                    List.Add(newCustomer);
                }

                return true;
            }
            else
            {
                return false;
            }

        }

        public bool UpdateDatabase()
        {
            try
            {
                string path = @"c:\Datenbanken\" + DataBaseName + ".csv";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(EncodeWord(Password, true));

                foreach (Customer customer in List)
                {

                    string line = customer.CustomerID.ToString() + ";"
                                + EncodeWord(customer.FirstName, true) + ";"
                                + EncodeWord(customer.LastName, true) + ";"
                                + EncodeWord(customer.EmailAddress, true) + ";"
                                + EncodeWord(customer.OpenBalance.ToString(), true) + ";"
                                + customer.LastChange.ToString();

                    sb.AppendLine(line);
                }
                File.WriteAllText(path, sb.ToString());

                return true;
            }
            catch (Exception)
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

            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool CheckEmail(string email)
        {
            if (List.Any(p => p.EmailAddress == email))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string EncodeWord(string word, bool toEncode)
        {
            List<char> right = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o','p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                                                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            List<char> wrong = new List<char> { 'z','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o','p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y',
                                                'Z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y',
                                                '9', '8', '7', '6', '5', '4', '3', '2', '1', '0' };

            char[] charArr = word.ToCharArray();
            char[] newCharArr = new char[charArr.Length];

            if (toEncode)
            {
                for (int i = 0; i < charArr.Length; i++)
                {
                    newCharArr[i] = wrong[right.IndexOf(charArr[i])];
                }


            }
            else
            {
                for (int i = 0; i < charArr.Length; i++)
                {
                    newCharArr[i] = right[wrong.IndexOf(charArr[i])];
                }
            }
            return new string(newCharArr);
        }
    }
}
#endregion

