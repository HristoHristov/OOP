using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Human_Student_and_Worker
{
    static class Sorting
    {
        private static IEnumerable<Human> mergeStudentsHuman = Student.GetStudent.OfType<Human>().Concat(Worker.GetWorker.OfType<Human>());
        public static IEnumerable<Human> SortingMergeObjectByFirstName()
        {
            IEnumerable<Human> result = merge.OrderBy(firstName => firstName.FirstName);
            return result;
        }
        public static IEnumerable<Human> SortingMergeObjectByLastName(IEnumerable<Human> merge)
        {
            IEnumerable<Human> result = merge.OrderBy(lastName => lastName.LastName);
            return result;
        }
    }
}
