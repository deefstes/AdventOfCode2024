using AdventOfCode2024.Utils.Graph;

namespace AdventOfCode2024.Utils.Pathfinding
{
    public interface IPathFinder<TNode> where TNode : IEquatable<TNode>, IComparable<TNode>
    {
        public bool HasSolution { get; }
        public long TotalCost { get; }
        public List<TNode> Path { get; }
    }
}
