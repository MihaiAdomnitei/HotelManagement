using Lab1.domain;
using System.Collections.Generic;

namespace Lab1.repository
{
    public interface ResultRepository : Repository<int, Result>
    {
        List<Participant> GetEvaluatedParticipants(Referee referee);
    }
}