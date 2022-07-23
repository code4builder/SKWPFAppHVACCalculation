using System.Collections.Generic;

namespace SKUWPFAppHVAC.Data.Content.ListsData
{
    internal class RectDuctsSize
    {
        public int RectDuctSingleSize { get; set; }
        public List<RectDuctsSize> RectDucts { get; set; }

        public RectDuctsSize(int size)
        {
            RectDucts = new List<RectDuctsSize>();
            RectDuctSingleSize = size;
        }
    }
}
