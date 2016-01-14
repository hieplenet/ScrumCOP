using System;
using JustigeLeague;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JustigeLeage.Tests
{
    [TestClass]
    public class BatmanShould
    {
        [TestMethod]
        public void Convert_Vowels_To_IAMBATMAN_If_String_Contains_More_Than_30_Percent_Vowel()
        {
            Assert.AreEqual("iambatman", Batman.IAMBATMANize("a"));
            Assert.AreEqual("biambatman", Batman.IAMBATMANize("ba"));
        }

        [TestMethod]
        public void Not_Convert_Vowels_To_IAMBATMAN_If_String_Contains_Less_Than_30_Percent_Vowel()
        {
            Assert.AreEqual("abbb", Batman.IAMBATMANize("abbb"));
        }
    }
}
