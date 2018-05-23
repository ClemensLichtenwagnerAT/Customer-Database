using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lichtenwagner Clemens
// Reitmayr Tobias

namespace Customer_Data
{
    /// <summary>
    /// TODO
    /// </summary>
    /// 
    public class Customer
    {
        #region Membervariablen
        private int _CustomerID;
        private string _FirstName;
        private string _LastName;
        private string _EmailAdresse;
        private double _OpenBalance;
        private DateTime _LastChange;
        #endregion

        #region Constructor
        public Customer(int customerID, string firstName, string lastName, string emailAdresse, double openBalance, DateTime lastChange)
        {
            this.CustomerID = customerID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAdresse;
            this.OpenBalance = openBalance;
            this.LastChange = lastChange;
        }

        public Customer(string firstName, string lastName, string emailAdresse, double openBalance, DateTime lastChange)
        {
            this.CustomerID = 0;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAdresse;
            this.OpenBalance = openBalance;
            this.LastChange = lastChange;
        }

        public Customer()
        {
        }

        #endregion

        #region Properties

        public int CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
            }
        }
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            private set
            {
                if (IsNameCorrect(value))
                {
                    this._FirstName = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Ivalid first name!");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this._LastName;
            }
            private set
            {
                if (IsNameCorrect(value))
                {
                    this._LastName = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Ivalid last name!");
                }
            }
        }

        public string EmailAddress
        {
            get
            {
                return this._EmailAdresse;
            }
            private set
            {
                this._EmailAdresse = value;
            }
        }

        public double OpenBalance
        {
            get
            {
                return this._OpenBalance;
            }
            private set
            {
                this._OpenBalance = value;
            }
        }

        public DateTime LastChange
        {
            get
            {
                return this._LastChange;
            }
            private set
            {
                this._LastChange = value;
            }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Changes the last name of a chosen customer
        /// </summary>
        /// <param name="newLastname">New last name</param>
        public void ChangeLastName(string newLastname)
        {
            try
            {
                this.LastName = newLastname;
                this.LastChange = DateTime.Now; // still needs to be tested
            }
            catch (Exception ex)
            {
                throw new ArgumentOutOfRangeException(ex.Message);
            }
        }
        /// <summary>
        /// Changes the e-mail address of a chosen customer
        /// </summary>
        /// <param name="newEmailAdress">New e-mail address</param>
        public void ChangeEmailAddress(string newEmailAdress)
        {
            try
            {
                this.EmailAddress = newEmailAdress;
                this.LastChange = DateTime.Now; // still needs to be tested
            }
            catch (Exception ex)
            {
                throw new ArgumentOutOfRangeException(ex.Message);
            }
        }

        /// <summary>
        /// Deposit on user account 
        /// </summary>
        /// <param name="amount">amount in €</param>
        public void PayIn(double amount)
        {
            this.OpenBalance += amount;
            this.LastChange = DateTime.Now; // noch zu testen
        }

        /// <summary>
        /// Withdraw money from user account
        /// </summary>
        /// <param name="amount">amount in €</param>
        public void PayOut(double amount)
        {
            this.OpenBalance -= amount;
            this.LastChange = DateTime.Now; // noch zu testen
        }

        public override string ToString()
        {
            string text;
            text = String.Format("Fist name: {0}", this.FirstName)
                + Environment.NewLine + String.Format("Last Name: {0} ", this.LastName)
                + Environment.NewLine + String.Format("E-mail address: {0} ", this.EmailAddress)
                + Environment.NewLine + String.Format("Money on the account: {0} ", this.OpenBalance);
            return (text);
        }

        #endregion

        #region Static methods
        public static bool IsNameCorrect(string name)
        {
            if ((name.Length < 2) || (Char.IsLower(name[0])) || (String.IsNullOrEmpty(name)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsEmailAddressCorrect(string emailAddress)
        {
            char[] charArr = emailAddress.ToCharArray();
            if (!(charArr.Count(p => p.Equals('@')) == 1))
            {
                return false;
            }

            string[] parts = emailAddress.Split('@');
            if (parts[0].Count() == 0)
            {
                return false;
            }
            if (!parts[1].Contains("."))
            {
                return false;
            }

            parts = emailAddress.Split('.');
            if (parts[parts.Count() - 1].Count() <= 1 || parts[parts.Count() - 1].Count() >= 5)
            {
                return false;
            }

            charArr = parts[parts.Count() - 1].ToCharArray();
            foreach (Char ch in charArr)
            {
                if (!Char.IsLetter(ch))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}