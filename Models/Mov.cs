namespace Mov.Models
{
    public class mov
    {
        public string movID { get; set; } = string.Empty;
        public byte[]? photo { get; set; }
        public string title { get; set; } = string.Empty;
        public string genre { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string url { get; set; } = string.Empty;

    }
}
