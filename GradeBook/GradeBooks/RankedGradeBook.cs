using System;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked Grading requires at least 5 students");
            }
            var threshold = (int)Math.Ceiling(Students.Count * .20);
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
            switch (averageGrade)
            {
                case var grade when grades[threshold - 1] <= averageGrade:
                    return 'A';

                case var grade when grades[threshold * 2 - 1] <= averageGrade:
                    return 'B';

                case var grade when grades[threshold * 3 - 1] <= averageGrade:
                    return 'C';

                case var grade when grades[threshold * 4 - 1] <= averageGrade:
                    return 'D';

                case var grade when grades[threshold * 5 - 1] <= averageGrade:
                    return 'E';

                default:
                    return 'F';
                    //checking F
            }
        }
    }
}