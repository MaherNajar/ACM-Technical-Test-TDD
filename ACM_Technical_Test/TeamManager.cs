﻿using System.Collections.Generic;
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

            var orderedTeams = Teams.OrderByDescending(x => x.TeamScore).ToList();
            int maxScore = orderedTeams.First().TeamScore;
            var bestTeams = orderedTeams.Where(x => x.TeamScore == maxScore).ToList();

            return new int[] { maxScore, bestTeams.Count() };
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