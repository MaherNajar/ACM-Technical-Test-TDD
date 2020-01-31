using System.Collections.Generic;

namespace ACM_Technical_Test
{
    public abstract class TeamManagerBase
    {
        protected string[] _data;

        protected IEnumerable<ITeam> Teams = null;

        public TeamManagerBase(string[] data)
        {
            _data = data;
            Teams = CreateTeams();
        }

        protected abstract IEnumerable<ITeam> CreateTeams();

        public abstract int[] GetBestTeams();
    }

}
