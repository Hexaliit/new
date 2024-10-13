using Exir.Client.Services;
using Microsoft.AspNetCore.Components;
using Shared.DTOs;
using Shared.Models;

namespace Exir.Client.Pages
{
    public partial class EditPerson
    {
        [Inject]
        IHttpRepository<Person> httpRepository { get; set; }


        [Parameter]
        public int? Id { get; set; }

        public PersonDto PersonDto { get; set; } = new PersonDto();

        private bool codeExists = false;

        private async Task HandleSubmit()
        {

        }

        private async Task CheckNationalCode()
        {
            if (PersonDto.NationalCode != null)
            {
                codeExists = true;
            }
            else
            {
                codeExists = false;
            }
        }

        protected override async Task OnParametersSetAsync()
        {
            if (Id == null)
            {
                PersonDto = new PersonDto();
            }
            else {
                var personDto = await httpRepository.Get("http://localhost:5173/api/persons/getById", (int)Id);
                if (personDto != null)
                {
                    PersonDto.FirstName = personDto.FirstName;
                    PersonDto.LastName = personDto.LastName;
                    PersonDto.Email = personDto.Email;
                    PersonDto.Phone = personDto.Phone;
                    PersonDto.NationalCode = personDto.NationalCode;
                    PersonDto.ProfileId = personDto.ProfileId;
                }
            }
        }
    }
}
