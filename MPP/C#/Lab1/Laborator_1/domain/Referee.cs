namespace Lab1.domain
{
    public class Referee : Entity<int>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Activity { get; set; }

        public Referee(int id, string username, string password, string firstName, string lastName, string activity) : base(id)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Activity = activity;
        }

        public override string ToString()
        {
            return $"Referee{{Username='{Username}', Password='{Password}', FirstName='{FirstName}', LastName='{LastName}', Activity='{Activity}'}}";
        }
    }
}