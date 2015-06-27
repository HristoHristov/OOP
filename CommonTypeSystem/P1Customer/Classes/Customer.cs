namespace P1Customer.Classes
{
    using System;
    using P1Customer.Enumeration;
    using System.Collections.Generic;
    class Customer : ICloneable, IComparable
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _id;
        private string _permanentAddress;
        private string _phone;
        private string _email;
        private List<Payment> _payments = new List<Payment>();
        private CustomerType _customerType;
        private bool isEquals = true;

        public Customer(string firstNname, string middleName, string lastName, string id, string permanentAddress,
            string mobilPhone, string email, List<Payment> payments, CustomerType customerType)
        {
            this.FirstName = firstNname;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermanentAddress = permanentAddress;
            this.PhoneNumber = mobilPhone;
            this.Email = email;
            this.AddPayment(payments);
            this.CustomerType = customerType;
        }
        public string FirstName 
        {
            get
            {
                return this._firstName;
            }
            set
            {
                CheckingData.CheckingString(value, 5, 40, "Invalid first name " + value);
                this._firstName = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return this._middleName;
            }
            set
            {
                CheckingData.CheckingString(value, 5, 40, "Invalid middle name " + value);
                this._middleName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                CheckingData.CheckingString(value, 5, 40, "Invalid last name " + value);
                this._lastName = value;
            }
        }
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                CheckingData.CheckingString(value, 10, 10, "Customer Id should be 10 characters.");
                this._id = value;
            }
        }
        public string PermanentAddress
        {
            get
            {
                return this._permanentAddress;
            }
            set
            {
                CheckingData.CheckingString(value, 10, 150, "Permanent Address should be from 10 and 150 characters");
                this._permanentAddress = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return this._phone;
            }
            set
            {
                CheckingData.CheckingString(value, 15, 15, "The phone number shouk be in format +XXXX XXXX XXXX");
                this._phone = value;
            }
        }
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                if(!value.Contains("@"))
                {
                    throw new FormatException("The email should be in format: example@ex.com");
                }
                this._email = value;
            }
        }
        public void AddPayment(List<Payment> peyments)
        {
            foreach (var payment in peyments)
            {
                this._payments.Add(payment);
            }
        }
        public List<Payment> GetPayment
        {
            get
            {
                return this._payments;
            }
        }
        public CustomerType CustomerType
        {
            get
            {
                return this._customerType;
            }
            set
            {
                this._customerType = value;
            }
        }
        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if(customer == null)
            {
                this.isEquals = false;
            }

            CheckingData.IsEquals(this._firstName, customer._firstName, ref this.isEquals);
            CheckingData.IsEquals(this._lastName, customer._lastName, ref this.isEquals);
            CheckingData.IsEquals(this._middleName, customer._middleName, ref this.isEquals);
            CheckingData.IsEquals(this._customerType, customer._customerType, ref this.isEquals);
            CheckingData.IsEquals(this._email, customer._email, ref this.isEquals);
            CheckingData.IsEquals(this._id, customer._id, ref this.isEquals);            
            CheckingData.IsEquals(this._permanentAddress, customer._permanentAddress, ref this.isEquals);
            CheckingData.IsEquals(this._phone, customer._phone, ref this.isEquals);
            return this.isEquals;
        }
        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }
        public static  bool operator !=(Customer customer1, Customer customer2)
        {
            return !(Customer.Equals(customer1, customer2));            
        }
        public override int GetHashCode()
        {
            var hashcode =  this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.Email.GetHashCode() ^
                this.GetPayment.GetHashCode() ^ this.ID.GetHashCode() ^ this.LastName.GetHashCode() ^ 
                this.PermanentAddress.GetHashCode() ^ this.PhoneNumber.GetHashCode();
            return hashcode;
        }
        public override string ToString()
        {
            string result = String.Format("\t\t\tCustomer: Full name: {0} {1} {2}\nID: {3} \t\t\t Address: {4}\nMobile Phone: {5}"+
               "\t\t\tEmail: {6} \n\t\t\t Purchases: \n", FirstName, MiddleName, LastName, ID, PermanentAddress, PhoneNumber, Email);
            foreach (var payment in this._payments)
            {
                result += payment + "\n";
            }
            return result;
        }

        public object Clone()
        {
            return new Customer((string)this._firstName.Clone(), (string)this._middleName.Clone(),
                (string)this._lastName.Clone(), (string)this._id.Clone(), (string)this._permanentAddress.Clone(),
                (string)this._phone.Clone(), (string)this._email.Clone(), this._payments, this._customerType);
                
        }

        public int CompareTo(object obj)
        {
            Customer customer = obj as Customer;
            return this.FirstName.CompareTo(customer.FirstName);
        }

        public int CompareTo(string other)
        {
            throw new NotImplementedException();
        }
    }
}
