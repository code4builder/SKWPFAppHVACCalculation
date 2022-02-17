using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUWPFAppHVAC.Data.Content.ListsData
{
    public class CircDuctsSize
    {
        public int CircDuctSingleSize { get; set; }
        public List<CircDuctsSize> CircDucts { get; set; }

        public CircDuctsSize(int size)
        {
            CircDucts = new List<CircDuctsSize>();
            CircDuctSingleSize = size;
        }
    }
}
