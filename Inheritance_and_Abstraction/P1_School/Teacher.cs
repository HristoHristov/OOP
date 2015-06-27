namespace P1_School
{
    using System;
    using System.Collections.Generic;
    class Teacher : Human
    {
        
        private List<Disciplines> _discipline = new List<Disciplines>();
        public Teacher(string name, string id, List<Disciplines> disc)
            : base (name, id)
        {
            this.AddDisciplines(disc);
        }

        public  void AddDisciplines(List<Disciplines> disciplines)
        {
            foreach (var discipline in disciplines)
            {
                this._discipline.Add(discipline);
               
            }
        }
        public List<Disciplines> GetDisciplines()
        {
            return this._discipline;
        }
         public override string ToString()
        {
            return String.Format("Teacher name: {0} - ID: {1} \n\tDiscipline: \n  {2}", this.Name, this.ID, this.GetDisciplines());
        }
        
    }
}
