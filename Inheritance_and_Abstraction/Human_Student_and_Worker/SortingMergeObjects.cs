using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Human_Student_and_Worker
{
    static class SortingMergeObjects
    {
        private static IEnumerable<Human> _margeWorkerStudent= Student.GetStudent.OfType<Human>().Concat(Worker.GetWorker.OfType<Human>());

        public static IEnumerable<Human> SortingMergeObjectByFirstName()
        {
            IEnumerable<Human> result = SortingMergeObjects._margeWorkerStudent.OrderBy(firstName => firstName.FirstName);
            return result;
        }
        public static IEnumerable<Human> SortingMergeObjectByLastName()
        {
            IEnumerable<Human> result = SortingMergeObjects._margeWorkerStudent.OrderBy(lastName => lastName.LastName);
            return result;
        }
    }
}
