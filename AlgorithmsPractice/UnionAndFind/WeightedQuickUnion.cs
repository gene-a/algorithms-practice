using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.UnionAndFind
{
    internal class WeightedQuickUnion : UnionAndFindBase
    {
        private int[] _nodeWeights;

        public WeightedQuickUnion(int size) :base(size)
        {
            _nodeWeights = new int[size];

            for(var i = 0; i < _nodeWeights.Length; i++)
            {
                _nodeWeights[i] = 1;
            }
            
        }

        public override bool Connected(int p, int q)
        {
            var result = false;

            // O(N)
            if (p >= 0 && q >= 0)
            {
                var p1 = GetCorrectedIndex(p);
                var q1 = GetCorrectedIndex(q);

                result = FindRootNode(p1) == FindRootNode(q1);
            }
            return result;
        }

        public override void Union(int p, int q)
        {
            // Logarithmic, O(logN)
            if (p >= 0 && q >= 0)
            {
                var p1 = GetCorrectedIndex(p);
                var q1 = GetCorrectedIndex(q);

                if (_nodeWeights[p1] >= _nodeWeights[q1]) 
                {
                    var topRootOfIdAtP = FindRootNode(p1);
                    _ids[q1] = topRootOfIdAtP;
                    _nodeWeights[p1] += _nodeWeights[q1];
                }
                else if (_nodeWeights[q1] >= _nodeWeights[p1])
                {
                    var topRootOfIdAtQ = FindRootNode(q1);
                    _ids[p1] = topRootOfIdAtQ;
                    _nodeWeights[q1] += _nodeWeights[p1];
                }
            }
        }
    }
}
