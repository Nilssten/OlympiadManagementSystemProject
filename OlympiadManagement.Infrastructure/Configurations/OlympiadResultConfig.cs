using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlympiadManagement.Core;
using OlympiadManagement.Core.Aggregates.UserProfileAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure.Configurations
{
    internal class OlympiadResultConfig : IEntityTypeConfiguration<OlympiadResult>
    {
        public void Configure(EntityTypeBuilder<OlympiadResult> builder)
        {
            builder.HasKey(or => or.OlympiadResultID);
            
        }
    }
}
