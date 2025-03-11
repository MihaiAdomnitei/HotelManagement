using Lab1.domain;
using Lab1.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.repository
{
    public class ResultRepositoryImpl : ResultRepository
    {
        private readonly Dictionary<int, Result> results = new Dictionary<int, Result>();

        public Result FindOne(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("ID must not be null");
            }
            if (!results.TryGetValue(id, out var result))
            {
                throw new InexistentEntityException("Result not found");
            }
            return result;
        }

        public IEnumerable<Result> GetAll()
        {
            return results.Values;
        }

        public void Clear()
        {
            results.Clear();
        }

        public void Save(Result result)
        {
            results[result.Id] = result;
        }

        public void Update(Result result)
        {
            if (!results.ContainsKey(result.Id))
            {
                throw new InexistentEntityException("Result not found");
            }
            results[result.Id] = result;
        }

        public void Delete(int id)
        {
            if (!results.ContainsKey(id))
            {
                throw new InexistentEntityException("Result not found");
            }
            results.Remove(id);
        }

        public List<Participant> GetEvaluatedParticipants(Referee referee)
        {
            return results.Values.Where(r => r.Referee.Equals(referee)).Select(r => r.Participant).ToList();
        }
    }
}