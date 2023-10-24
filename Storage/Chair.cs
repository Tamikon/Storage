using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class Chair // стул
    {
        public string Firm { get; set; }

        public string Material { get; set; }

        public Chair(string firm, string material)
        {
            Firm = firm;
            Material = material;
        }
    }
}
