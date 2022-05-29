using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using OlympiadManagement.Infrastructure.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Areas.Administrative.Pages.UserManagement.Components
{
    //TODO::Refactor whole this section
    public partial class UserList : ComponentBase
    {
        [CascadingParameter]
        public string SelectedUsers { get; set; }

        [Inject] public UserManager<AppUser> userManager { get; set; }

        public bool Busy { get; set; } = false;

       
        public List<Participant> Participants { get; set; }
        public List<Admin> Admins { get; set; }
        public List<Applicant> Applicants { get; set; }
        public List<Evaluator> Evaluators { get; set; }
        public List<Organizer> Organizers { get; set; }



        public IList<AppUser> AppUsers { get; set; }




        //TODO:: refactor
        protected override async Task OnParametersSetAsync()
        {
            if (SelectedUsers is not null)
            {
                var selected = await userManager.GetUsersInRoleAsync(SelectedUsers.ToLower());
                AppUsers = selected;
            }
        }

    }
}
