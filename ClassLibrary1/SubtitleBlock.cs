namespace SubtitleLib
{
    public class SubtitleBlock
    {
        public string BlockNumber;
        public string StartTime;
        public string EndTime;
        public string TextContent;

        public SubtitleBlock(string blockNumber, string startTime, string endTime, string textContent)
        {
            BlockNumber = blockNumber;
            StartTime = startTime;
            EndTime = endTime;
            TextContent = textContent;
        }

        public override string ToString()
        {
            return $"{this.BlockNumber}\n{this.StartTime} --> {this.EndTime}\n{this.TextContent}\n";
        }
    }
}