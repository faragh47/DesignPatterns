using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ImageStorage
    {
        public ImageStorage()
        {

        }


        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.compress(fileName);
            filter.apply(fileName) ;
        }

    }
}
