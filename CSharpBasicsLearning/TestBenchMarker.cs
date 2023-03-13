using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsLearning
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class TestBenchMarker
    {
        Helper helper= new Helper();

        [Benchmark]
        public int Test()
        {
          return helper.GetYearFromDate( DateTime.Now.ToString());
        }

    }
}
