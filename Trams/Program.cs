using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramDepot
{
    class Program
    {
        static void Main(string[] args)
        {
            //dummy data, should already be in a file
            /*
            Driver d1 = new Driver("Peter", "Smith", Experience.Novice);
            Driver d2 = new Driver("Frank", "Castle", Experience.Expert);
            Driver d3 = new Driver("Jessica", "Jones", Experience.Advanced);

            Tram t1 = new Tram(1, Condition.Excellent, "A", d1);
            Tram t2 = new Tram(2, Condition.ForParts, "B");
            Tram t3 = new Tram(3, Condition.ForParts, "14", d2);
            Tram t4 = new Tram(4, Condition.NeedRepairs, "AE");
            Tram t5 = new Tram(5, Condition.Good, "22", d3);

            HashSet<Driver> drivers = new HashSet<Driver>() { d1, d2, d3 };
            HashSet<Tram> trams = new HashSet<Tram>() { t1, t2, t3, t4, t5 };

            FileUtils.Serialize<HashSet<Driver>>(drivers, "../../drivers.json");
            //TODO save only id of drivers
            FileUtils.Serialize<HashSet<Tram>>(trams, "../../trams.json");
            */

            //demo
            Tram t6 = new Tram(1, Condition.Good, "14");
            Administration.AddTram(t6);

            HashSet<Tram> tramsList = Administration.GetTramsList();
            HashSet<Tram> tramsNoDriverList = Administration.GetTramsNoDriverList();
            Tram tram = Administration.GetTram(3);

            Console.WriteLine("tramsList:");
            tramsList.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            Console.WriteLine("tramsNoDriverList:");
            tramsNoDriverList.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            Console.WriteLine("tram:");
            Console.WriteLine(tram);
        }
    }
}
