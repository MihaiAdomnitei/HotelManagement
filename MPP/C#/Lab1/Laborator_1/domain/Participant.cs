namespace Lab1.domain
{
    public class Participant : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Points { get; set; }

        public Participant(int id, string firstName, string lastName, int points) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Points = points;
        }

        public override string ToString()
        {
            return $"Participant{{FirstName='{FirstName}', LastName='{LastName}', Points={Points}}}";
        }
    }
}