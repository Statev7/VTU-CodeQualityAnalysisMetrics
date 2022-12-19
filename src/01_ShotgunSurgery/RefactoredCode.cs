namespace _01_SRP
{
    using System;

    public class RefactoredCode
    {
        public class Person
        {
            private const string INVALID_NAME_ERROR_MESSAGE = "{0} cannot be null or empty!";

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
                    ValidateNames(value, nameof(this.FirstName));

                    this.firstName = value;
                }
            }

            public string MiddleName
            {
                get => this.middleName;
                private set
                {
                    ValidateNames(value, nameof(this.MiddleName));

                    this.middleName = value;
                }
            }

            public string LastName
            {
                get => this.lastName;
                private set
                {
                    ValidateNames(value, nameof(this.LastName));

                    this.lastName = value;
                }
            }

            private static void ValidateNames(string value, string nameOf)
            {
                if (string.IsNullOrEmpty(value))
                {
                    var errorMesssage = string.Format(INVALID_NAME_ERROR_MESSAGE, nameOf);

                    throw new ArgumentNullException(errorMesssage);
                }
            }
        }
    }
}
