using ArrayReversal;
using NUnit.Framework;

namespace ArrayReversalTests
{
    public class ArrayUtilTests
    {
        private int[] _input;
        private int[] _expected;

        [SetUp]
        public void SetUp()
        {
            _input = new[] { 1, 2, 3, 4, 5, 6, 7 };
            _expected = new[] { 7, 6, 5, 4, 3, 2, 1 };
        }

        [Test]
        public void WhenIamNoob()
        {
            var actual = ArrayUtil.reverseLikeNoob(_input);
            for (var i = 0; i < _input.Length; i++)
            {
                Assert.AreEqual(_expected[i], actual[i]);
            }
        }

        [Test]
        public void WhenIamPro()
        {
            var actual = ArrayUtil.reverseLikePro(_input);
            for (var i = 0; i < _input.Length; i++)
            {
                Assert.AreEqual(_expected[i], actual[i]);
            }
        }

        [Test]
        public void WhenIamZenMaster()
        {
            var actual = ArrayUtil.reverseLikeZenMaster(_input);
            for (var i = 0; i < _input.Length; i++)
            {
                Assert.AreEqual(_expected[i], actual[i]);
            }
        }
    }
}
