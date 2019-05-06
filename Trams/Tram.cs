using Newtonsoft.Json;

namespace TramDepot
{
    public enum Condition
    {
        Excellent,
        Good,
        NeedRepairs,
        ForParts
    }
    public class Tram
    {
        private int id;
        private Condition condition;
        private string line;
        [JsonProperty] //makes possible writing of a field into a file
        private Driver driver;

        public int Id { get => id; set => id = value; }
        public Condition Condition { get => condition; set => condition = value; }
        public string Line { get => line; set => line = value; }
        internal Driver Driver { get => driver; set => driver = value; }

        public Tram(int id, Condition condition, string line, Driver driver = null)
        {
            Id = id;
            Condition = condition;
            Line = line;
            Driver = driver;
        }

        public override bool Equals(object obj)
        {
            var tram = obj as Tram;
            return tram != null && Id == tram.Id;
        }

        public override int GetHashCode()
        {
            var hashCode = 1118581916;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            string driverName;
            if (driver == null)
            {
                driverName = "none";
            }
            else
            {
                driverName = driver.LastName;

            }
            return "id: " + id + ", condition: " + condition + ", line: " + line + ", driver: " + driverName;
        }
    }
}
