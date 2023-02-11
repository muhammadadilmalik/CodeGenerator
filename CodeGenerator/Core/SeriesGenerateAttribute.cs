using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Core
{
    public class SeriesGenerateAttribute: Attribute
    {
        private string prefix;
        public SeriesGenerateAttribute(string prefix)
        {
            this.prefix = prefix;
        }
        public string GetPrefix()
        {
            return prefix;
        }
    }
}
