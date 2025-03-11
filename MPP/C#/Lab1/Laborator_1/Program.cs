using Lab1.domain;
using Lab1.repository;
using System;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ParticipantRepository participantRepo = new ParticipantRepositoryImpl();
            RefereeRepository refereeRepo = new RefereeRepositoryImpl();
            ResultRepository resultRepo = new ResultRepositoryImpl();

            Referee ref1 = new Referee(1, "john_swim", "pass123", "John", "Smith", "swimming");
            Referee ref2 = new Referee(2, "mary_run", "pass456", "Mary", "Johnson", "running");

            refereeRepo.Save(ref1);
            refereeRepo.Save(ref2);

            Participant p1 = new Participant(1, "Alice", "Wilson", 0);
            Participant p2 = new Participant(2, "Bob", "Davis", 0);

            participantRepo.Save(p1);
            participantRepo.Save(p2);

            Result r1 = new Result(1, p1, ref1, "swimming", 85);
            resultRepo.Save(r1);

            Console.WriteLine("Referees:");
            foreach (var referee in refereeRepo.GetAll())
            {
                Console.WriteLine(referee);
            }

            Console.WriteLine("\nParticipants:");
            foreach (var participant in participantRepo.GetAll())
            {
                Console.WriteLine(participant);
            }

            Console.WriteLine("\nResults:");
            foreach (var result in resultRepo.GetAll())
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("\nSwimming referees:");
            foreach (var referee in refereeRepo.FindByActivity("swimming"))
            {
                Console.WriteLine(referee);
            }

            Console.WriteLine("\nParticipants evaluated by ref1:");
            foreach (var participant in resultRepo.GetEvaluatedParticipants(ref1))
            {
                Console.WriteLine(participant);
            }
        }
    }
}