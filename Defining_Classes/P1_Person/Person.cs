namespace P1_Person
{
    using System;

    class Person
    {
        private string name;
        private int age;
        private string email = "empty";

        public Person(string name, int age)
            : this(name, age, null)
        { }
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < 1 || value.Length > 100)
                {
                    throw new ArgumentOutOfRangeException("the username should be from 1 to 100 characters!");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("the age should be from 1 to 100!");
                }
                this.age = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (!value.Contains("@"))
                    {
                        throw new ArgumentNullException("Please be sure that you are entering your email in this format: Ex: email@careerbuilder.com!");
                    }
                    this.email = value;
                }

            }
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Email: {2}", this.name, this.age, this.email);
        }
    }
}
