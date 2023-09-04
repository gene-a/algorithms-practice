namespace AlgorithmsPractice.UnionAndFind
{
    internal class QuickFind : UnionAndFindBase
    {
        public QuickFind(int size) : base(size)
        {
        }

        public override bool Connected(int p, int q)
        {
            var result = false;
            // Constant, O(1)
            if (p >= 0 && q >= 0)
            {
                result = _ids[GetCorrectedIndex(p)] == _ids[GetCorrectedIndex(q)];
            }
            return result;
        }

        public override void Union(int p, int q)
        {
            // Quadratic, O(n^2)
            // Depending on array size operation will have to access the array again and again untill all IDs have been updated as necessary
            if (p >= 0 && q >= 0)
            {
                var valueP = _ids[GetCorrectedIndex(p)];
                var valueQ = _ids[GetCorrectedIndex(q)];

                for (var i = 0; i < _ids.Length; i++)
                {
                    if (_ids[i] == valueP)
                    {
                        _ids[i] = valueQ;
                    }
                }
            }
        }
    }
}
