namespace TramDepot
{
    public enum Experience
    {
        Novice,
        Intermediate,
        Advanced,
        Expert
    }
    public class Driver
    {
        private string firstName;
        private string lastName;
        private Experience experience;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public Experience Experience { get => experience; set => experience = value; }

        public Driver(string firstName, string lastName, Experience experience)
        {
            FirstName = firstName;
            LastName = lastName;
            Experience = experience;
        }
    }
}
