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
        public List<Game> RentedGames { get; set; } = new List<Game>();

        public Customer(int customerID, string name)
        {
            CustomerID = customerID;
            Name = name;
        }

        public void RentGame(Game game) { 
            RentedGames.Add(game);
            Console.WriteLine($"{game.Title} kikölcsönözve!");
        }        
        
        public void ReturnGame(Game game) { 
            RentedGames.Remove(game);
            Console.WriteLine($"{game.Title} visszahozva!");
        }

        public override string? ToString()
        {
            return $"[{CustomerID}] - {Name} Kölcsönött játékok: {String.Join(", ",RentedGames)}";
        }
    }
}
