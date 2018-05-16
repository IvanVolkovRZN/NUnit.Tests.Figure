using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests.Figure
{
    class AbstractTest
    {
        protected static int ROUDING = 6;
        private static int BOUND = 20;

        public static int[] GeometricCircleSquare()
        {
            return Enumerable.Range(0, BOUND + 1).ToArray();
        }
    }
}
