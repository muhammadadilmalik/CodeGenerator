using CodeGenerator.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Entities
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [SeriesGenerate("USER")]
        [MaxLength(50)]
        public string? Code { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }
    }
}
