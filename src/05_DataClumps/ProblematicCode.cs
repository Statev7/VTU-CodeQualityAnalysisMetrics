namespace _05_DataClumps
{
    using System;

    public class ProblematicCode
    {
        public class Course
        {
            public Course(string name, DateTime startDate, DateTime endDate)
            {
                this.Name = name;
                this.StartDate = startDate;
                this.EndDate = endDate;
            }

            public string Name { get; init; }

            public DateTime StartDate { get; init; }

            public DateTime EndDate { get; init; }
        }

        public class Seminar
        {
            public Seminar(string name, DateTime startDate, DateTime endDate)
            {
                this.Name = name;
                this.StartDate = startDate;
                this.EndDate = endDate;
            }

            public string Name { get; init; }

            public DateTime StartDate { get; init; }

            public DateTime EndDate { get; init; }
        }
    }
}
