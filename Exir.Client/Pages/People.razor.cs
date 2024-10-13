using Exir.Client.Services;
using Microsoft.AspNetCore.Components;
using Shared.Models;

namespace Exir.Client.Pages
{
    public partial class People
    {
        [Inject] IHttpRepository<Person> httpRepository {  get; set; }

        private List<Person> _people;

        protected override async Task OnInitializedAsync()
        {
            _people = await httpRepository.GetAll("http://localhost:5173/api/persons/getall");
        }

    }
}
