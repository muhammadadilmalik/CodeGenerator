using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Entities
{
    public class ConfigSeries
    {
        public long Id { get; set; }
        [MaxLength(100)]
        public string SeriesType { get; set; }
        public long MaxNumber { get; set; }
    }
}
