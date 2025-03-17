using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class RentalService
    {
       private List<Game> games { get; set; }=new List<Game>();
       private List<Customer> customers { get; set; }=new List<Customer>();

        public RentalService()
        {
        }


        public void AddGame(Game game) { 
            games.Add(game);
        }

        public void AddCustomer(Customer customer) {
            customers.Add(customer);
        }

        public IEnumerable<Game> ListGames() {
            return games.Where(x=>x.IsAvailable);
        }        
        
        public List<Customer> ListCustomer() {
            return customers;
        }


        public Boolean RentGame(string customerName, string gameId) {

            Customer customer = customers.FirstOrDefault(x => x.Name == customerName);
            Game game = games.FirstOrDefault(g => g.GameID == gameId);

            if (customer != null && game != null)
            {
                customer.RentGame(game); 
            }
            else return false;
            return true;
        }
    }
}
