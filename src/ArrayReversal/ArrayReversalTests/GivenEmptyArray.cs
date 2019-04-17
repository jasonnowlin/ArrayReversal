using ArrayReversal;
using NUnit.Framework;

namespace ArrayReversalTests
{
    public class GivenEmptyArray
    {
        private int[] _input;
        private int[] _expected;

        [SetUp]
        public void SetUp()
        {
            _input = new int[0];
            _expected = new int[0];
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
