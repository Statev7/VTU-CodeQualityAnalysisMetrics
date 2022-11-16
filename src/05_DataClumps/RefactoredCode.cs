namespace _05_DataClumps
{
    using System;

    public class RefactoredCode
    {
        public class TimeDuration
        {
            public TimeDuration(DateTime startDate, DateTime endDate)
            {
                this.StartDate = startDate;
                this.EndDate = endDate;
            }

            public DateTime StartDate { get; init; }

            public DateTime EndDate { get; init; }
        }

        public class Course
        {
            public Course(string name, DateTime startDate, DateTime endDate)
            {
                this.Name = name;
                this.Duration = new TimeDuration(startDate, endDate);
            }

            public string Name { get; init; }

            public TimeDuration Duration { get; init; }
        }

        public class Seminar
        {
            public Seminar(string name, DateTime startDate, DateTime endDate)
            {
                this.Name = name;
                this.Duration = new TimeDuration(startDate, endDate);
            }

            public string Name { get; init; }

            public TimeDuration Duration { get; init; }
        }
    }
}
