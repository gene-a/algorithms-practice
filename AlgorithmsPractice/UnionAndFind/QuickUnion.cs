﻿namespace AlgorithmsPractice.UnionAndFind
{
    internal class QuickUnion : UnionAndFindBase
    {
        public QuickUnion(int size) : base(size)
        {
        }

        protected int FindRootNode(int i)
        {
            return _ids[i] == i ? i : FindRootNode(_ids[i]);
        }

        public override bool Connected(int p, int q)
        {
            // Linear, O(N) due to tree height
            if (p >= 0 && q >= 0)
            {
                var qRoot = _ids[GetCorrectedIndex(q)];
                var pRoot = _ids[GetCorrectedIndex(p)];
                
                // If they're already equal return true
                if (pRoot == qRoot)
                {
                    return true;
                }

                // If not then we go find the rootest of the rootz
                return FindRootNode(pRoot) == FindRootNode(qRoot);
            }
            return false;
        }

        public override void Union(int p, int q)
        {
            // Constant, O(1)
            if (p >= 0 && q >= 0)
            {
                _ids[GetCorrectedIndex(p)] = _ids[GetCorrectedIndex(q)];
            }
        }
    }
}