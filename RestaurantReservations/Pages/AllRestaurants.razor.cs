using Microsoft.AspNetCore.Components;
using RestaurantReservations.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestaurantReservations.Pages
{
    public class AllRestaurantsModel : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }
        [Parameter]
        public int ParamEmpID { get; set; }
        [Parameter]
        public string Action { get; set; }

        protected List<Restaurant> empList = new List<Restaurant>();
        protected override async Task OnParametersSetAsync()
        {
            await FetchRestaurantAll();
        }
        protected async Task FetchRestaurantAll()

        {
            empList = await Http.GetJsonAsync<List<Restaurant>>("https://localhost:44361/api/Restaurant/Index");
        }
    }
}
