using System.Collections.Generic;
using System.Linq;

namespace ACM_Technical_Test
{
    public class Team : ITeam
    {
        private readonly List<Person> Persons = null;

        public int TeamScore { get; private set; }
        public Team(params string[] data)
        {
            Persons = new List<Person>();
            foreach (string row in data)
            {
                Persons.Add(new Person(row));
            }

            CalculateTeamScore();
        }

        private void CalculateTeamScore()
        {

            int topicsLength = Persons[0]._knowledge.Length;

            for (int i = 0; i < topicsLength; i++)
            {
                if (Persons.Any(p => p.KnowTopic(i)))
                    TeamScore++;
            }
        }
    }

}
