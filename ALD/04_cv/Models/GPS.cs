using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _04_cv.Models
{
    public class GPS
    {
        class Path
        {
            public int lenght;
            public string cityName;
            public int time;

            public Path(string cityName, int value, int time)
            {
                this.lenght = value;
                this.cityName = cityName;
                this.time = time;
            }
        }
        private List<string> cities = new List<string>()
        {
            "liberec",
            "ceska-lipa",
            "chrastava",
            "new-york",
            "turnov",
            "jablonec-nad-nisou"
        };
        private List<List<int>> times = new List<List<int>>()
        {
            new List<int>() { 999, 999, 12, 24, 22, 20 },
            new List<int>() { 999,999, 40, 10, 52,999 },
            new List<int>() {  12, 40,999, 20,999,999},
            new List<int>() { 24, 10, 20,999, 15, 30},
            new List<int>() { 22, 52,999, 15,999, 22},
            new List<int>() { 20,999,999, 30, 22,999 },
        };
        private List<List<int>> lenghts = new List<List<int>>()
        {
            new List<int>() { 999,999, 10, 35, 26, 20 },
            new List<int>() { 999,999, 47, 30, 67,999 },
            new List<int>() { 10, 47,999, 14,999,999 },
            new List<int>() { 35, 30, 14,999, 40, 30 },
            new List<int>() { 26, 67,999, 40,999, 24 },
            new List<int>() { 20,999,999, 30, 24,999 }
        };

        public string GetNejkratsi(string startCity, string destinationCity)
        {
            string way = startCity;
            int index = cities.IndexOf(startCity);
            List<Path> shortestPaths = new List<Path>();
            for (int i = 0; i < 6; i++)
            {
                if(i == index)
                {
                    shortestPaths.Add(new Path("", 0, 0));
                }
                shortestPaths.Add(new Path("", 999, 999));
            }
            while(true)
            {
                if (index != cities.IndexOf(startCity))
                {
                    way = way + " -> " + cities[index];
                }
                //index = shortestPaths.IndexOf(shortestPaths.Min());
                foreach(Path path in shortestPaths)
                {
                    if(Math.Abs(shortestPaths[index].lenght) < Math.Abs(path.lenght))
                    {
                        index = shortestPaths.IndexOf(path);
                    }
                }
                if(index == cities.IndexOf(destinationCity))
                {
                    return $"({shortestPaths[index].time} min - {shortestPaths[index].lenght} km) {way}";
                }
                for (int i = 0; i < 6; i++)
                {
                    if (lenghts[index][i] != 999 && shortestPaths[i].lenght > (lenghts[index][i] + shortestPaths[index].lenght) && shortestPaths[i].lenght!=-999)
                    {
                        shortestPaths[i].lenght = lenghts[index][i] + shortestPaths[index].lenght;
                        shortestPaths[i].cityName = cities[index];
                        shortestPaths[i].time = times[index][i] + shortestPaths[index].time;
                    }
                }
                shortestPaths[index].lenght = -999;
            }
        }
    }
}
