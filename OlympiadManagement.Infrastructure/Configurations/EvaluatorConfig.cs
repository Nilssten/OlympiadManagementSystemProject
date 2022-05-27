using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure.Configurations
{
    internal class EvaluatorConfig : IEntityTypeConfiguration<Evaluator>
    {
        public void Configure(EntityTypeBuilder<Evaluator> builder)
        {
            builder.HasKey(ev => ev.EvaluatorID);
        }
    }
}
