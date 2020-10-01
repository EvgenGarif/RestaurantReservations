using Microsoft.AspNetCore.Components;
using RestaurantReservations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestaurantReservations.Pages
{
    public class RestaurantItemModel : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }
        //[Inject]
        //public NavigationManager UrlNavigationManager { get; set; }

        [Parameter]
        public int ParamEmpID { get; set; }
        [Parameter]
        public string Action { get; set; }
        protected List<Table> tableList = new List<Table>();
        protected List<Client> clientList = new List<Client>();
        protected Restaurant restaurant = new Restaurant();

    protected string Title { get; set; }

        public bool Check(int i)
        { 
            bool a = false;
            var s = clientList.Where(t => t.TableId == i);
            foreach (var resev in s)
            {
                if (DateTime.Now >= resev.BookingTime && DateTime.Now <= resev.DurationOfBooking)
                {
                    a = true;
                    break;
                }
            }
            return a;
        }

        protected override async Task OnParametersSetAsync()
        {
            restaurant = await Http.GetJsonAsync<Restaurant>("https://localhost:44361/api/Restaurant/Details/" + ParamEmpID);
            tableList = await Http.GetJsonAsync<List<Table>>("https://localhost:44361/api/tables/DetailsTable/" + ParamEmpID);
            clientList = await Http.GetJsonAsync<List<Client>>("https://localhost:44361/api/tables/DetailsClient/" + ParamEmpID);
        }

        
       
       
    }

    
}
