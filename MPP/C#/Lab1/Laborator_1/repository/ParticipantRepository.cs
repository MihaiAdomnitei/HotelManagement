using Lab1.domain;
using System.Collections.Generic;

namespace Lab1.repository
{
    public interface ParticipantRepository : Repository<int, Participant>
    {
        List<Participant> FindByActivityOrderedDescByPoints(string activity);
    }
}