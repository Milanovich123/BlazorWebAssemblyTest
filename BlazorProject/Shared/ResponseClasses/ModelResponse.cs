using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared.ResponseClasses
{
    public class ModelResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public bool IsChecked { get; set; }
    }
}
