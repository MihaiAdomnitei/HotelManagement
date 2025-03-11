using Lab1.domain;
using Lab1.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.repository
{
    public class RefereeRepositoryImpl : RefereeRepository
    {
        private readonly Dictionary<int, Referee> referees = new Dictionary<int, Referee>();

        public Referee FindOne(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("ID must not be null");
            }
            if (!referees.TryGetValue(id, out var referee))
            {
                throw new InexistentEntityException("Referee not found");
            }
            return referee;
        }

        public IEnumerable<Referee> GetAll()
        {
            return referees.Values;
        }

        public void Clear()
        {
            referees.Clear();
        }

        public void Save(Referee referee)
        {
            if (referees.ContainsKey(referee.Id))
            {
                throw new ExistentEntityException("Referee already exists!");
            }
            referees[referee.Id] = referee;
        }

        public void Update(Referee referee)
        {
            if (!referees.ContainsKey(referee.Id))
            {
                throw new InexistentEntityException("Referee not found");
            }
            referees[referee.Id] = referee;
        }

        public void Delete(int id)
        {
            if (!referees.ContainsKey(id))
            {
                throw new InexistentEntityException("Referee not found");
            }
            referees.Remove(id);
        }

        public List<Referee> FindByActivity(string activity)
        {
            return referees.Values.Where(r => r.Activity == activity).ToList();
        }
    }
}