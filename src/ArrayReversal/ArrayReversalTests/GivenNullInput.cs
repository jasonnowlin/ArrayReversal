using ArrayReversal;
using NUnit.Framework;

namespace ArrayReversalTests
{
    public class GivenNullInput
    {
        private int[] _input;

        [SetUp]
        public void SetUp()
        {
            _input = null;
        }

        [Test]
        public void WhenIamNoob()
        {
            var actual = ArrayUtil.reverseLikeNoob(_input);
            Assert.IsNull(actual);
        }

        [Test]
        public void WhenIamPro()
        {
            var actual = ArrayUtil.reverseLikePro(_input);
            Assert.IsNull(actual);
        }

        [Test]
        public void WhenIamZenMaster()
        {
            var actual = ArrayUtil.reverseLikeZenMaster(_input);
            Assert.IsNull(actual);
        }

        [Test]
        public void WhenIamMicrosoft()
        {
            var actual = ArrayUtil.reverseLikeMicrosoft(_input);
            Assert.IsNull(actual);
        }

        [Test]
        public void WhenICopyAndReverse()
        {
            var actual = ArrayUtil.copyAndReverse(_input);
            Assert.IsNull(actual);
        }
    }
}
