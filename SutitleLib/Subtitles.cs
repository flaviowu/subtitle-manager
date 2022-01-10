using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SubtitleLib
{
    public class Subtitles
    {
        public static List<SubtitleBlock> Parse(string subtitleString)
        {

            Regex rx = new Regex(
          @"(?<blockNumber>\d+)\r\n(?<startTime>\d{2}\:\d{2}\:\d{2},\d{3}) --\> " +
          @"(?<endTime>\d{2}\:\d{2}\:\d{2},\d{3})\r\n(?<textContent>[\s\S]*?\r\n)",
          RegexOptions.Compiled | RegexOptions.ECMAScript);

            List<SubtitleBlock> subtitleBlocksArray = new List<SubtitleBlock>();
            foreach (Match match in rx.Matches(subtitleString))
            {
                SubtitleBlock subtitleBlock = new SubtitleBlock(
                    match.Groups["blockNumber"].Value,
                    match.Groups["startTime"].Value,
                    match.Groups["endTime"].Value,
                    match.Groups["textContent"].Value
                    );
                subtitleBlocksArray.Add(subtitleBlock);

            }
            return subtitleBlocksArray;
        }

        public static List<SubtitleBlock> Offset(List<SubtitleBlock> subtitles, double offsetTime)
        {
            foreach (SubtitleBlock block in subtitles)
            {
                block.StartTime = String.Format("{0:HH\\:mm\\:ss\\,fff}", DateTime.Parse(block.StartTime.Replace(",", ".")).AddSeconds(offsetTime));
                block.EndTime = String.Format("{0:HH\\:mm\\:ss\\,fff}", DateTime.Parse(block.EndTime.Replace(",", ".")).AddSeconds(offsetTime));
            }
            return subtitles;
        }
    }
}
