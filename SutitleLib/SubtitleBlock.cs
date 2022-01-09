namespace SubtitleLib
{
    public class SubtitleBlock
    {
        private string _blockNumber;
        private string _startTime;
        private string _endTime;
        private string _textContent;

        public SubtitleBlock(string blockNumber, string startTime, string endTime, string textContent)
        {
            _blockNumber = blockNumber;
            _startTime = startTime;
            _endTime = endTime;
            _textContent = textContent;
        }

        public string BlockNumber
        {
            get => this._blockNumber;
        }

        public string StartTime
        {
            get => this._startTime;
            set => this._startTime = value;
        }

        public string EndTime
        {
            get => this._endTime;
            set => this._endTime = value;
        }

        public string TextContext
        {
            get => this._textContent;
            set => this._textContent = value;
        }

        public override string ToString()
        {
            return $"{this._blockNumber}\n{this._startTime} --> {this._endTime}\n{this._textContent}\n";
        }

    }
}