using System.Collections.Generic;

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
