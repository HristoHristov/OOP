namespace P2_Human_Student_and_Worker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Worker : Human
    {
        private double _weekSalary;
        private double _workHoursPerDay;
        private static List<Worker> _worker = new List<Worker>();
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHourPerDay = workHoursPerDay;
            this.AddWorker();
        }
        public  double WeekSalary
        {
            get {return this._weekSalary;} 
            set
            {
                this.CheckedDigits(value);
                this._weekSalary = value;
                
            }
        }
        public double WorkHourPerDay
        {
            get { return this._workHoursPerDay; }
            set
            {
                this.CheckedDigits(value);
                this._workHoursPerDay = value;
            }
        }
        public void  CheckedDigits(double inputDigit)
        {
            if(inputDigit <= 0)
            {
                throw new FormatException("The input data should be more than 0!");                
            }
        }
        private  void AddWorker()
        {
            Worker._worker.Add(this);
        }
        public static List<Worker> GetWorker
        {
            get { return Worker._worker; }
        }
        public double MoneyPerHour()
        {
            double result = (this._weekSalary / 5) / this._workHoursPerDay;
            return result;
        }
        public static IEnumerable<Worker> Sorting()
        {

             IEnumerable<Worker> sorting = Worker.GetWorker.OrderByDescending(salary => salary.MoneyPerHour());
             return sorting;
        }

    }
}
