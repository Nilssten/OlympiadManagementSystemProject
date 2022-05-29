using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OlympiadManagement.Core;
using OlympiadManagementSystem.Data.Services.DomainServices;

namespace OlympiadManagementSystem.Areas.Olympiads.Pages
{
    public class OlympiadListModel : PageModel
    {
        private IOlympiadService _olympiadService;

       
        public bool Busy { get; set; } = false;
 
        public bool Error { get; set; } = false;
        public string ErrorMessage { get; set; }
        public List<Olympiad> Olympiads { get; set; }

        public OlympiadListModel(IOlympiadService olympiadService)
        {
            _olympiadService = olympiadService;
        }

        public async Task OnGet()
        {
            try
            {
                Busy = true;
                Olympiads = await _olympiadService.GetOlympiadsAsync();
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
