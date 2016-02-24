using System;
using JustigeLeague;
using NUnit.Framework;

namespace JustigeLeage.Tests
{
    [TestFixture]
    public class BatmanShould
    {
        private Batman batman;
        
        [SetUp]
        public void Initialize()
        {
            batman = new Batman();
        }

        [Test]
        public void Convert_Vowels_To_IAMBATMAN_If_String_Contains_More_Than_30_Percent_Vowel()
        {
            Assert.AreEqual("iambatman", batman.IAMBATMANize("a"));
            Assert.AreEqual("biambatman", batman.IAMBATMANize("ba"));
        }

        [Test]
        public void Not_Convert_Vowels_To_IAMBATMAN_If_String_Contains_Less_Than_30_Percent_Vowel()
        {
            Assert.AreEqual("abbb", batman.IAMBATMANize("abbb"));
        }

        [Test]
        public void Not_Do_Batmanize_If_User_Has_Not_Log_In()
        {
            batman.IAMBATMANize("a");
        }
    }
}
