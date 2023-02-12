using CodeGenerator.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Entities
{
    public class Company
    {
        [Key]
        public long Id { get; set; }

        [SeriesGenerate("COMP")]
        [MaxLength(50)]
        public string? Code { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string? Name1 { get; set; }
        [MaxLength(256)]
        public string? Name2 { get; set; }
        [MaxLength(256)]
        public string? Name3 { get; set; }
        [MaxLength(256)]
        public string? Name4 { get; set; }
        [MaxLength(256)]
        public string? Name5 { get; set; }
        [MaxLength(256)]
        public string? Name6 { get; set; }

        [MaxLength(256)]
        public string? Name7 { get; set; }
        [MaxLength(256)]
        public string? Name8 { get; set; }
        [MaxLength(256)]
        public string? Name9 { get; set; }
        [MaxLength(256)]
        public string? Name10 { get; set; }
        [MaxLength(256)]
        public string? Name11 { get; set; }
        [MaxLength(256)]
        public string? Name12 { get; set; }
        [MaxLength(256)]
        public string? Name13 { get; set; }
        [MaxLength(256)]
        public string? Name14 { get; set; }
        [MaxLength(256)]
        public string? Name15 { get; set; }
        [MaxLength(256)]
        public string? Name16 { get; set; }
        [MaxLength(256)]
        public string? Name17 { get; set; }
        [MaxLength(256)]
        public string? Name18 { get; set; }
        [MaxLength(256)]
        public string? Name19 { get; set; }
        [MaxLength(256)]
        public string? Name20 { get; set; }
        [MaxLength(256)]
        public string? Name21 { get; set; }
        [MaxLength(256)]
        public string? Name22 { get; set; }
        [MaxLength(256)]
        public string? Name23 { get; set; }
    }
}
