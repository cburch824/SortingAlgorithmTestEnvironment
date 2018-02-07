using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SortingAlgorithmTestEnvironment
{
    class SortingGraph
    {
        string graphName;
        Image graphImage;

        public SortingGraph(string graphName, Image graphImage)
        {
            this.graphName = graphName;
            this.graphImage = graphImage;
        }
    }
}
