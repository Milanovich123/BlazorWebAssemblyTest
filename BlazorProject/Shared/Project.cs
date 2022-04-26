using BlazorProject.Shared.ResponseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared
{
    public class Project
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public UserResponse Owner { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public SitelocationResponse SiteLocation { get; set; }

        public Uri ImageUrl { get; set; }

        public List<ModelResponse> models { get; set; }
    }
}
