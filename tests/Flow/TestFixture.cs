using Fuzzy;

namespace Athene.Flow;

public abstract class TestFixture
{
    protected static readonly IFuzz fuzzy = new RandomFuzz();
}
