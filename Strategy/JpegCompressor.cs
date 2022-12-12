using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class JpegCompressor : ICompressor
    {
        public void compress(string fileName)
        {
            Console.WriteLine("compress image " +fileName+ "with jpeg Converter");
        }
    }
}
