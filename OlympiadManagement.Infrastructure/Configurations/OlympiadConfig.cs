using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlympiadManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure.Configurations
{
    internal class OlympiadConfig : IEntityTypeConfiguration<Olympiad>
    {
        public void Configure(EntityTypeBuilder<Olympiad> builder)
        {
            builder.HasKey(ol => ol.OlympiadID);
            builder.OwnsOne(ol => ol.Rules);
        }
    }
}
