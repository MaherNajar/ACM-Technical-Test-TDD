using System.Collections.Generic;
using System.Linq;

namespace ACM_Technical_Test
{
    public class TeamManager : TeamManagerBase
    {
        public TeamManager(string[] data) : base(data)
        {
        }

        public override int[] GetBestTeams()
        {
            if (!Teams.Any())
            {
                return new int[] { 0, 0 };
            }

            var orderedQueueTeams = new Queue<ITeam>(Teams.OrderByDescending(x => x.TeamScore));

            var maxScore = orderedQueueTeams.First().TeamScore;

            int bestTeamsCount = 0;

            while (orderedQueueTeams.First().TeamScore == maxScore)
            {
                orderedQueueTeams.Dequeue();
                bestTeamsCount++;
            };

            return new int[] { maxScore, bestTeamsCount };
        }

        protected override IEnumerable<ITeam> CreateTeams()
        {
            int PersonsCount = _data.Length;

            for (int i = 0; i < PersonsCount; i++)
            {
                for (int j = i + 1; j < PersonsCount; j++)
                {
                    yield return new Team(_data[i], _data[j]);
                };
            };

        }
    }

}
