using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public List<Game> RentedGames { get; set; }


    }
}
