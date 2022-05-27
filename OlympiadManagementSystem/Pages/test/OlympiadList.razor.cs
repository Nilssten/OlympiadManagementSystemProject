using Microsoft.AspNetCore.Components;
using OlympiadManagement.Core;
using OlympiadManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Pages.test
{
    public partial class OlympiadList : ComponentBase
    {

        [Inject] IOlympiadService olimpiadService { get; set; }


        public List<Olympiad> Olympiad { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //Olympiad = await olimpiadService.GetOlympiadsAsync();
            
        }
       

    }
}
