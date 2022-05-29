using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Areas.Administrative.Pages.UserManagement.Components
{
    public partial class SelectUser : ComponentBase
    {

        public string SelectedUser { get; set; }
        [Inject] public AuthenticationStateProvider _provider { get; set; }
        public bool SuperAdmin { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            var state = await _provider.GetAuthenticationStateAsync();
            if (state.User.IsInRole("superadmin"))
            {
                SuperAdmin = true;
            }

        }


        public void SelectedUsersChanged(ChangeEventArgs e)
        {
            if (e.Value is not null)
            {
                SelectedUser = (string)e.Value;
            }

        }

    }
}
