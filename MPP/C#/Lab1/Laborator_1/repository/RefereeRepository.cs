using Lab1.domain;
using System.Collections.Generic;

namespace Lab1.repository
{
    public interface RefereeRepository : Repository<int, Referee>
    {
        List<Referee> FindByActivity(string activity);
    }
}