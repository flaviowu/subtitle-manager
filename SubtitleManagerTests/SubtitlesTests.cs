using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace SubtitleLib.Tests
{
    [TestClass()]
    public class SubtitlesTests
    {
        // Test Parse
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
            var result = subtitles[0].ToString();
            Assert.AreEqual(result, subtitleString);
        }

        // Test Offset
        [TestMethod()]
        public void OffsetTest_Output_StartTime()
        {
            string subtitleString = "1\n00:00:00,000 --> 00:00:03,000\nSome Text and more text to test.\n";
            string startTime = "00:00:01,125";
            double offset = 1.125;

            ArrayList subtitles = Subtitles.Parse(subtitleString);
            ArrayList syncedSubtitles = Subtitles.Offset(subtitles, offset);
            var result = subtitles[0].StartTime;

            Assert.IsTrue(result == startTime);

        }

        [TestMethod()]
        public void OffsetTest_Output_EndTime()
        {
            string subtitleString = "1\n00:00:00,000 --> 00:00:03,000\nSome Text and more text to test.\n";
            string endTime = "00:00:04,125";
            double offset = 1.125;

            ArrayList subtitles = Subtitles.Parse(subtitleString);
            ArrayList syncedSubtitles = Subtitles.Offset(subtitles, offset);
            var result = subtitles[0].EndTime;

            Assert.IsTrue(result == endTime);

        }

    }
}