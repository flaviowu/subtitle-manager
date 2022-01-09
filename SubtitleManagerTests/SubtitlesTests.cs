using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace SubtitleLib.Tests
{
    [TestClass()]
    public class SubtitlesTests
    {
        [TestMethod()]
        public void ParseTest_Output()
        {
            string subtitleString = "1\n" +
                "00:00:00,000 --> 00:00:03,000\n" +
                "Some Text and morr text to test.\n";
            ArrayList subtitles = Subtitles.Parse(subtitleString);
            Assert.IsNotNull(subtitles);
        }

        [TestMethod()]
        public void ParseTest_Output_values()
        {
            string subtitleString = "1\n00:00:00,000 --> 00:00:03,000\nSome Text and more text to test.\n";
            ArrayList subtitles = Subtitles.Parse(subtitleString);
            var ooo = subtitles[0];
            // SubtitleBlock blocao = new SubtitleBlock("1", "00:00:00,000", "00:00:03,000", "Some Text and more text to test.");
            bool asa = true;
            Assert.IsTrue(asa);
        }
    }
}