﻿namespace AlgorithmsPractice.UnionAndFind
{
    internal abstract class UnionAndFindBase
    {
        protected int[] _ids;
        public UnionAndFindBase(int size)
        {
            _ids = new int[size];

            for(var i = 0; i < size; i++)
            {
                _ids[i] = i;
            }
        }

        public abstract void Union(int p, int q);
        
        // i.e. Find
        public abstract bool Connected(int p, int q);

        protected int GetCorrectedIndex(int i)
        {
            return i == 0 ? 0 : i - 1;
        }

        protected int FindRootNode(int i)
        {
            return _ids[i] == i ? i : FindRootNode(_ids[i]);
        }
    }
}
