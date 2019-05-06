using System.Collections.Generic;
using System.Linq;

namespace TramDepot
{
    public class Administration
    {
        public static bool AddTram(Tram newTram)
        {
            //load from file
            HashSet<Tram> trams = FileUtils.Deserialize<HashSet<Tram>>("../../trams.json");
            //if no file
            if (trams == null)
            {
                trams = new HashSet<Tram>();
            }
            //if alredy exists
            if (trams.Contains(newTram))
            {
                return false;
            }
            trams.Add(newTram);
            //save file
            FileUtils.Serialize<HashSet<Tram>>(trams, "../../trams.json");
            return true;
        }

        public static HashSet<Tram> GetTramsList()
        {
            //load from file
            HashSet<Tram> trams = FileUtils.Deserialize<HashSet<Tram>>("../../trams.json");
            //if no file or empty
            if (trams == null || trams.Count == 0)
            {
                return new HashSet<Tram>();
            }
            return trams;
        }
        
        public static HashSet<Tram> GetTramsNoDriverList()
        {
            //load from file
            HashSet<Tram> trams = FileUtils.Deserialize<HashSet<Tram>>("../../trams.json");
            //if no file or empty
            if (trams == null || trams.Count == 0)
            {
                return new HashSet<Tram>();
            }
            //check all trams and delete the ones with driver
            for (int i = 0; i < trams.Count; i++)
            {
                if (trams.ElementAt(i).Driver != null)
                {
                    trams.Remove(trams.ElementAt(i));
                }
            }
            return trams;
        }

       public static Tram GetTram(int id)
        {
            //load from file
            HashSet<Tram> trams = FileUtils.Deserialize<HashSet<Tram>>("../../trams.json");
            //if no file or empty
            if (trams == null || trams.Count == 0)
            {
                return null;
            }
            //check all trams and find the one with same id
            for (int i = 0; i < trams.Count; i++)
            {
                if (trams.ElementAt(i).Id == id)
                {
                    return trams.ElementAt(i);
                }
            }
            return null;
        }
    }
}
