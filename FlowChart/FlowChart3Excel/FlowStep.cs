using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowChart3Excel
{
    public class FlowStep
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public List<string> Next { get; set; } = new List<string>();
    }
}
