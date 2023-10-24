using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class Sofa // диван
    {
        public string Firm { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public string Material { get; set; }

        public Sofa(string firm, int width, int length, string material)
        {
            Firm = firm;
            Width = width;
            Length = length;
            Material = material;
        }
    }
}
