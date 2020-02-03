namespace ACM_Technical_Test
{

    public class Person : IPerson
    {
        public readonly string _knowledge;

        public Person(string knowledge)
        {
            _knowledge = knowledge;
        }

        public bool KnowTopic(int index)
        {
            return _knowledge[index].ToString() == "1";
        }
    }

}
