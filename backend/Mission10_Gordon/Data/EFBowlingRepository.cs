using Microsoft.EntityFrameworkCore;

namespace Mission10_Gordon.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlContext;
        public EFBowlingRepository(BowlingLeagueContext temp) {
            _bowlContext = temp;
        }
       // public IEnumerable<Bowler> Bowlers => _bowlContext.Bowlers;
        public IEnumerable<Bowler> GetMarlinsSharks()
        {
            return _bowlContext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                .ToList();
        }
    }
}
