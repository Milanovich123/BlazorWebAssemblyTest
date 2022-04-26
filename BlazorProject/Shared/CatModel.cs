using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared
{
    public class CatModel
    {
        public int current_page { get; set; }
        public Cat[] data { get; set; }
        public string first_page_url { get; set; }
        public int from { get; set; }
        public int last_page { get; set; }
        public string last_page_url { get; set; }
        public Link[] links { get; set; }
        public string next_page_url { get; set; }
        public string path { get; set; }
        public int per_page { get; set; }
        public object prev_page_url { get; set; }
        public int to { get; set; }
        public int total { get; set; }
    }

    public class Cat
    {
        public string breed { get; set; }
        public string country { get; set; }
        public string origin { get; set; }
        public string coat { get; set; }
        public string pattern { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public string label { get; set; }
        public bool active { get; set; }
    }


}


