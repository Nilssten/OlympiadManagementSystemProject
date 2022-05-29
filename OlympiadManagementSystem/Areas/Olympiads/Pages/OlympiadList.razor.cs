using Microsoft.AspNetCore.Components;
using OlympiadManagement.Core;
using OlympiadManagementSystem.Data.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Areas.Olympiads.Pages
{
    public partial class OlympiadList : ComponentBase
    {
        [Inject] public IOlympiadService OlympiadService { get; set; }


        public bool Busy { get; set; } = false;

        public bool Error { get; set; } = false;
        public string ErrorMessage { get; set; }
        public List<Olympiad> Olympiads { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Busy = true;
                Olympiads = await OlympiadService.GetOlympiadsAsync();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                Error = true;
            }
            finally
            {
                Busy = false;
            }
        }

        
    }
}
