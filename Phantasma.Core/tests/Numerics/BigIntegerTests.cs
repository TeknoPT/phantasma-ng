using System.Numerics;
using Phantasma.Core.Numerics;
using Shouldly;
using Xunit;

namespace Phantasma.Core.Tests.Numerics;

public class BigIntegerTests
{
    [Fact]
    public void byte_array_to_big_integer()
    {
        var byteArray = new byte[] {42};
        var bigInteger = byteArray.AsBigInteger();
        bigInteger.ShouldBe(42);
    }

    [Fact]
    public void big_integer_to_byte_array()
    {
        BigInteger bigInteger = 42;
        var byteArray = bigInteger.AsByteArray();
        byteArray.ShouldBe(new byte[] {42});
    }
}
