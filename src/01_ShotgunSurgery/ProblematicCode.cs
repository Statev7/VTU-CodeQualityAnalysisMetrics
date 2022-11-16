namespace _01_SRP
{
    using System;

    public class ProblematicCode
    {
        public class Person
        {
            private string firstName;
            private string middleName;
            private string lastName;

            public Person(string firstName, string middleName, string lastName)
            {
                this.FirstName = firstName;
                this.MiddleName = middleName;
                this.LastName = lastName;
            }

            public string FirstName
            {
                get => this.firstName;
                private set
                {
                    if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("First name cannot be null!");

                    this.firstName = value;
                }
            }

            public string MiddleName
            {
                get => this.middleName;
                private set
                {
                    if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Middle name cannot be null!");

                    this.middleName = value;
                }
            }

            public string LastName
            {
                get => this.lastName;
                private set
                {
                    if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Last name cannot be null!");

                    this.lastName = value;
                }
            }
        }
    }
}
