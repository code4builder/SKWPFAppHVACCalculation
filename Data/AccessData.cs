using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKUWPFAppHVAC.Data.Content.ListsData;

namespace SKUWPFAppHVAC.Data
{
    internal class AccessData
    {
        public AccessData()
        {
            //Creating of Size List for Rectangular Ducts
            RectDuctsSizesList = new List<RectDuctsSize>();
            for (int i = 100; i < 1501; i += 50)
            {
                RectDuctsSizesList.Add(new RectDuctsSize(i));
            }

            //Creating of Size List for Circular Ducts
            CircDuctsSizesList = new List<CircDuctsSize>();
            CircDuctsSizesList.Add(new CircDuctsSize(100));
            CircDuctsSizesList.Add(new CircDuctsSize(125));
            CircDuctsSizesList.Add(new CircDuctsSize(160));

        }
        public List<RectDuctsSize> RectDuctsSizesList { get; set; }
        public List<CircDuctsSize> CircDuctsSizesList { get; set; }

    }
}
