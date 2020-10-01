using Microsoft.AspNetCore.Components;
using RestaurantReservations.Model;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestaurantReservations.Pages
{
    public class ClientItemModel : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }
        [Inject]
        public NavigationManager UrlNavigationManager { get; set; }

        [Parameter]
        public int ParamEmpID { get; set; }
        [Parameter]
        public string Action { get; set; }

        protected Client client = new Client();

        protected string Title { get; set; }
        protected async Task CreateReservation()
        {
            client.TableId = ParamEmpID;
           
                await Http.SendJsonAsync(HttpMethod.Post, "https://localhost:44361/api/clients/create/", client);

            UrlNavigationManager.NavigateTo("/Completed");
        }     
    }
}
