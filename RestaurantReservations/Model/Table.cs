using Newtonsoft.Json;
using System.Collections.Generic;

namespace RestaurantReservations.Model
{
    public class Table
    {
      
        public int Id { get; set; }
        public int ItemTable { get; set; }
        public int RestaurantId { get; set; }

        [JsonIgnore]
        public Restaurant Restaurantes { get; set; }
        [JsonIgnore]
        public ICollection<Client> Clients { get; set; }

    }
}
