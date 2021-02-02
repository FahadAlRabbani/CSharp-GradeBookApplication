using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            var output = (averageGrade * Students.Count) / 100;

            if (output >= 20.0)
                return 'A';
            if (output >= 40.0 && output < 20.0)
                return 'B';
            if (output >= 60.0 && output < 40.0)
                return 'C';
            if (output >= 80.0 && output < 60.0)
                return 'D';

            return 'F';
        }
    }
}
