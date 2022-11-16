namespace _02_LongParameterList
{
    public class RefactoredCode
    {
        public interface IAddress
        {
            string Name { get; }

            int Number { get; }
        }

        public class Address : IAddress
        {
            public string Name { get; init; }

            public int Number { get; init; }
        }

        public class Person
        {
            public Person(string firstName, int age, IAddress address)
            {

            }
        }
    }
}
