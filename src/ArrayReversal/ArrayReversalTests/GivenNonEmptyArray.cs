using ArrayReversal;
using NUnit.Framework;

namespace ArrayReversalTests
{
    public class GivenNonEmptyArray
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
            Assert.AreEqual(_expected, actual);
        }

        [Test]
        public void WhenIamPro()
        {
            var actual = ArrayUtil.reverseLikePro(_input);
            Assert.AreEqual(_expected, actual);
        }

        [Test]
        public void WhenIamZenMaster()
        {
            var actual = ArrayUtil.reverseLikeZenMaster(_input);
            Assert.AreEqual(_expected, actual);
        }

        [Test]
        public void WhenIamMicrosoft()
        {
            var actual = ArrayUtil.reverseLikeMicrosoft(_input);
            Assert.AreEqual(_expected, actual);
        }

        [Test]
        public void WhenICopyAndReverse()
        {
            var actual = ArrayUtil.copyAndReverse(_input);
            Assert.AreEqual(_expected, actual);
        }
    }
}
