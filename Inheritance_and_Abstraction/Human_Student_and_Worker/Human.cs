namespace P2_Human_Student_and_Worker
{
    using System;
    abstract class Human
    {
        private string _firstName;
        private string _lastName;
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get { return this._firstName; } 
            set
            {
                this.CheckData(value);
                this._firstName = value;
            }
        }
        public string LastName
        {
            get { return this._lastName; }
            set
            {
                this.CheckData(value);
                this._lastName= value;
            }
        }

        public void CheckData(string inputData)
        {
            if((string.IsNullOrEmpty(inputData)) || (inputData.Length < 3 || inputData.Length > 50))
            {
                throw new FormatException("Invalid input data" + inputData);
            }
        }
    }
}
