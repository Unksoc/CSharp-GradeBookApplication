using GradeBook.GradeBooks;
using Xunit;

namespace GradeBookTests
{
    public class RankedGradeBookTest
    {
        [Fact]
        public void GetLetterGrade()
        {
            RankedGradeBook book = new RankedGradeBook("Book");
            book.AddStudent(new GradeBook.Student("John", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.National));
            book.AddStudent(new GradeBook.Student("John1", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.National));
            book.AddStudent(new GradeBook.Student("John2", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.National));
            book.AddStudent(new GradeBook.Student("John3", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.National));
            book.AddStudent(new GradeBook.Student("John4", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.National));
            book.AddStudent(new GradeBook.Student("John5", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.National));
            book.AddStudent(new GradeBook.Student("John6", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.National));
            book.AddStudent(new GradeBook.Student("John7", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.National));
            book.AddStudent(new GradeBook.Student("John8", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.National));
            book.AddStudent(new GradeBook.Student("John9", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.National));
            //book.AddStudent(new GradeBook.Student("John10", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.National));
            book.AddGrade("John", 25);
            book.AddGrade("John1", 29);
            book.AddGrade("John2", 50);
            book.AddGrade("John3", 10);
            book.AddGrade("John4", 11);
            book.AddGrade("John5", 21);
            book.AddGrade("John6", 21);
            book.AddGrade("John7", 21);
            book.AddGrade("John8", 21);
            book.AddGrade("John9", 21);
            book.AddGrade("John9", 21);
            ;
            Assert.Equal("F", book.GetLetterGrade(3).ToString());
        }
    }
}