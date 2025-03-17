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

        public List<Game> ListGames() {
            return games;
        }        
        
        public List<Customer> ListCustomer() {
            return customers;
        }

    }
}
