using System.Globalization;

namespace IbmMQTestApp.Entities
{
    public class SimpleMessage
    {
        public byte[] Id { get; set; }

        public string Content { get; set; }

        public string TimeStamp { get; set; }

        public string User { get; set; }

        public string Application { get; set; }

        public string StringId => BitConverter.ToString(Id).Replace("-", "");

        public string ListViewContent => (Content.Length < 100 ? Content : Content.Substring(0, 99) + "...");
    }
}
