namespace Lab1.domain
{
    public class Result : Entity<int>
    {
        public Participant Participant { get; set; }
        public Referee Referee { get; set; }
        public string Activity { get; set; }
        public int Points { get; set; }

        public Result(int id, Participant participant, Referee referee, string activity, int points) : base(id)
        {
            Participant = participant;
            Referee = referee;
            Activity = activity;
            Points = points;
        }
    }
}