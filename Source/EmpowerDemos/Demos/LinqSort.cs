using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerDemos.Demos
{
    public class CityInfo
    {
        string cityName;
        string countryName;
        int pop2010;

        public CityInfo(string name, string country, int pop2010)
        {
            this.cityName = name;
            this.countryName = country;
            this.pop2010 = pop2010;
        }
        public string City { get { return this.cityName; } }
        public string Country { get { return this.countryName; } }
        public int Population { get { return this.pop2010; } }

    }

    class LinqSort
    {
        public static void DemoLinqSort()
        {
            CityInfo NYC = new CityInfo("New York City", "United States of America", 8175133);
            CityInfo Det = new CityInfo("Detroit", "United States of America", 713777);
            CityInfo Paris = new CityInfo("Paris", "France", 2193031);
            List<CityInfo> cities = new List<CityInfo>() { NYC, Det, Paris };

            Console.WriteLine("排序之前！");
            DisplayArray(cities);
            //非原地排序:cities保持不变，生成一个新的list，升序排列
            List<CityInfo> sortedListUp = cities.OrderBy(x => x.Population).ToList();
            Console.WriteLine("非原地排序，升序结果！");
            DisplayArray(sortedListUp);
            //非原地排序:cities保持不变，生成一个新的list，升序排列
            List<CityInfo> sortedListDown = cities.OrderByDescending(x => x.Population).ToList();
            Console.WriteLine("非原地排序，降序结果！");
            DisplayArray(sortedListDown);

            //原地排序：修改Cities的顺序,升序排列
            cities.Sort((x, y) => {
                if (x == null) return -1;
                if (y == null) return 1;
                return x.Population.CompareTo(y.Population);
            });
            Console.WriteLine("原地排序后的结果！");
            DisplayArray(cities);
        }
        private static void DisplayArray(List<CityInfo> cities)
        {
            Console.WriteLine("{0,-20} {1,-25} {2,10}", "City", "Country", "Population");
            foreach (var city in cities)
                Console.WriteLine("{0,-20} {1,-25} {2,10:N0}", city.City,
                                  city.Country, city.Population);

            Console.WriteLine();
        }
    }
}
