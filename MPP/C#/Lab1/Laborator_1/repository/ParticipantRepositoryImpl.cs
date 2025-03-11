using Lab1.domain;
using Lab1.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.repository
{
    public class ParticipantRepositoryImpl : ParticipantRepository
    {
        private readonly Dictionary<int, Participant> participants = new Dictionary<int, Participant>();

        public Participant FindOne(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("ID must not be null");
            }
            if (!participants.TryGetValue(id, out var participant))
            {
                throw new InexistentEntityException("Participant not found");
            }
            return participant;
        }

        public IEnumerable<Participant> GetAll()
        {
            return participants.Values;
        }

        public void Clear()
        {
            participants.Clear();
        }

        public void Save(Participant participant)
        {
            if (participants.ContainsKey(participant.Id))
            {
                throw new ExistentEntityException("Participant already exists!");
            }
            participants[participant.Id] = participant;
        }

        public void Update(Participant participant)
        {
            if (!participants.ContainsKey(participant.Id))
            {
                throw new InexistentEntityException("Participant not found");
            }
            participants[participant.Id] = participant;
        }

        public void Delete(int id)
        {
            if (!participants.ContainsKey(id))
            {
                throw new InexistentEntityException("Participant not found");
            }
            participants.Remove(id);
        }

        public List<Participant> FindByActivityOrderedDescByPoints(string activity)
        {
            return participants.Values.OrderByDescending(p => p.Points).ToList();
        }
    }
}