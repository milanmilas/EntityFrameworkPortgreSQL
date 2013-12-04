using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPortgreSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ChinookContext())
            {
                var artists = from a in db.Artists
                              where a.Name.StartsWith("A")
                              orderby a.Name
                              select a;

                foreach (var artist in artists)
                {
                    Console.WriteLine(artist.Name);
                }
            }
        }
    }
}
