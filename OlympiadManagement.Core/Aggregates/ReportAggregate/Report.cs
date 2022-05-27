using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core.Aggregates.ReportAggregate
{
    public class Report
    {

        public Guid ReportID { get; set; }
        public Guid UserID { get; set; }
        public ReportIssueTopic IssueTopic { get; set; }

        public string ReportBody { get; set; }

    }
}
